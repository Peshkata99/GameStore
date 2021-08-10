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
    using GameStore.Services.Games;

    public class GamesController : Controller
    {
        private readonly IGameService games;
        private readonly GameStoreDbContext data;

        public GamesController(IGameService games,GameStoreDbContext data)
        {
            this.games = games;
            this.data = data;
        }

        public IActionResult All([FromQuery] AllGamesQueryModel query)
        {
            var queryResult = this.games.All(
                query.Genre,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllGamesQueryModel.GamesPerPage);

            var genreNames = this.games.AllGameGenres();

            query.Genres = genreNames;
            query.TotalGames = queryResult.TotalGames;
            query.Games = queryResult.Games;

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