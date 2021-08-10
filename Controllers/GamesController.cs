namespace GameStore.Controllers
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using GameStore.Models.Games;
    using GameStore.Infrastructure;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Authorization;

    public class GamesController : Controller
    {
        private readonly GameStoreDbContext data;

        public GamesController(GameStoreDbContext data) => this.data = data;

        public IActionResult All([FromQuery] AllGamesQueryModel query)
        {
            var gamesQuery = this.data.Games.AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.Genre))
            {
                gamesQuery = gamesQuery.Where(g => g.Genre.Name == query.Genre);
            }

            if (!string.IsNullOrWhiteSpace(query.SearchTerm))
            {
                gamesQuery = gamesQuery.Where(g =>
                    (g.Name).ToLower().Contains(query.SearchTerm.ToLower()) ||
                    g.Description.ToLower().Contains(query.SearchTerm.ToLower()));
            }

            gamesQuery = query.Sorting switch
            {
                GameSorting.ReleaseDate => gamesQuery.OrderByDescending(g => g.ReleaseYear),
                GameSorting.Genre => gamesQuery.OrderBy(g => g.Genre),
                GameSorting.DescendingPrice => gamesQuery.OrderByDescending(g => g.Price),
                GameSorting.AscendingPrice or _ => gamesQuery.OrderBy(g => g.Price)
            };

            var totalGames = gamesQuery.Count();

            var games = gamesQuery
                .Skip((query.CurrentPage - 1) * AllGamesQueryModel.GamesPerPage)
                .Take(AllGamesQueryModel.GamesPerPage)
                .Select(g => new GameListingViewModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ReleaseDate= g.ReleaseYear,
                    ImageUrl = g.ImageUrl,
                })
                .ToList();

            var genreNames = this.data
                .Genres
                .Select(g => g.Name)
                .Distinct()
                .OrderBy(n => n)
                .ToList();

            query.TotalGames = totalGames;
            query.Genres = genreNames;
            query.Games = games;

            return View(query);
        }
        [Authorize]
        public IActionResult Add() 
        {

            if (!this.UserIsSeller())
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            return View(new AddGameFormModel
            {
                Genres = this.GetGameGenres()
            });
        }

        [HttpPost]
        public IActionResult Add(AddGameFormModel game)
        {
            var sellerId = this.data
                .Sellers
                .Where(d => d.UserId == this.User.GetId())
                .Select(d => d.Id)
                .FirstOrDefault();

            if (sellerId == 0)
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            if (!this.data.Genres.Any(g => g.Id == game.GenreId))
            {
                this.ModelState.AddModelError(nameof(game.GenreId), "Genre does not exist");
            }

            if (!ModelState.IsValid)
            {
                game.Genres = this.GetGameGenres();

                return View(game);
            }

            var gameData = new Game
            {
                Name = game.Name,
                Price = game.Price,
                Description = game.Description,
                Developer = game.Developer,
                ReleaseYear = game.ReleaseYear,
                ImageUrl = game.ImageUrl,
                GenreId = game.GenreId,
                SellerId = sellerId
            };

            this.data.Games.Add(gameData);
            this.data.SaveChanges();

            return RedirectToAction(nameof(All));
        }
        private bool UserIsSeller()
            => this.data
                .Sellers
                .Any(d => d.UserId == this.User.GetId());

        private IEnumerable<GameGenreViewModel> GetGameGenres()
            => this.data
                .Genres
                .Select(g => new GameGenreViewModel
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList();
    }
}