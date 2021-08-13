namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Models.Games;
    using GameStore.Services.Games;
    using GameStore.Services.Sellers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class GamesController : Controller
    {
        private readonly IGameService games;
        private readonly ISellerService sellers;

        public GamesController(IGameService games,ISellerService sellers)
        {
            this.games = games;
            this.sellers = sellers;
        }

        public IActionResult All([FromQuery] AllGamesQueryModel query)
        {
            var queryResult = this.games.All(
                query.Genre,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllGamesQueryModel.GamesPerPage);

            var genreNames = this.games.AllGenreNames();

            query.Genres = genreNames;
            query.TotalGames = queryResult.TotalGames;
            query.Games = queryResult.Games;

            return View(query);
        }

        [Authorize]
        public IActionResult Mine()
        {
            var ownedGames = this.games.OwnedByUser(this.User.Id());

            return View(ownedGames);
        }

        [Authorize]
        public IActionResult Add() 
        {
            if (!this.sellers.IsSeller(this.User.Id()))
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            return View(new GameFormModel
            {
                Genres = this.games.AllGameGenres()
            });
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(GameFormModel game)
        {
            var sellerId = this.sellers.IdByUser(this.User.Id());

            if (sellerId == 0)
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            if (!this.games.GenreExists(game.GenreId))
            {
                this.ModelState.AddModelError(nameof(game.GenreId), "Genre does not exist");
            }

            if (!ModelState.IsValid)
            {
                game.Genres = this.games.AllGameGenres();

                return View(game);
            }

            this.games.Create(
                game.Name,
                game.Price,
                game.Description,
                game.Developer,
                game.ReleaseYear,
                game.ImageUrl,
                game.GenreId,
                sellerId);

            return RedirectToAction(nameof(All));
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var userId = this.User.Id();

            if (!this.sellers.IsSeller(userId) && !User.IsAdmin())
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            var game = this.games.Details(id);

            if (game.UserId != userId && !User.IsAdmin())
            {
                return Unauthorized();
            }

            this.games.Delete(id);

            return RedirectToAction(nameof(All));
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var userId = this.User.Id();

            if (!this.sellers.IsSeller(userId) && !User.IsAdmin())
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            var game = this.games.Details(id);

            if(game.UserId != userId && !User.IsAdmin())
            {
                return Unauthorized();
            }

            return View(new GameFormModel
            {
                Name = game.Name,
                Price = game.Price,
                Description = game.Description,
                Developer = game.Developer,
                ImageUrl = game.ImageUrl,
                ReleaseYear = game.ReleaseDate,
                GenreId = game.GenreId,
                Genres = this.games.AllGameGenres()
            });
        }
        [HttpPost]
        [Authorize]
        public IActionResult Edit(int id,GameFormModel game)
        {
            var sellerId = this.sellers.IdByUser(this.User.Id());

            if(sellerId == 0 && !User.IsAdmin())
            {
                return RedirectToAction(nameof(SellersController.Become), "Sellers");
            }

            if (!this.games.GenreExists(game.GenreId))
            {
                this.ModelState.AddModelError(nameof(game.GenreId), "Genre does not exist.");
            }

            if (!ModelState.IsValid)
            {
                game.Genres = this.games.AllGameGenres();

                return View(game);
            }

            if (!this.games.OwnedBySeller(id, sellerId) && !User.IsAdmin())
            {
                return BadRequest();
            }

            this.games.Edit(
                id,
                game.Name,
                game.Price,
                game.Description,
                game.Developer,
                game.ReleaseYear,
                game.ImageUrl,
                game.GenreId);

            return RedirectToAction(nameof(All));
        }
    }
}