namespace GameStore.Controllers
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using GameStore.Models.Games;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class GamesController : Controller
    {
        private readonly GameStoreDbContext data;

        public GamesController(GameStoreDbContext data) => this.data = data;

        public IActionResult Add() => View(new AddGameFormModel {
            Genres = this.GetGameGenres()
        });

        [HttpPost]
        public IActionResult Add(AddGameFormModel game)
        {
            if (!this.data.Genres.Any(g => g.Id == game.GenreId))
            {
                this.ModelState.AddModelError(nameof(game.Genres), "Genre does not exist");
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
                GenreId = game.GenreId
            };

            this.data.Games.Add(gameData);
            this.data.SaveChanges();
            
            return RedirectToAction("Index","Home");
        }

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