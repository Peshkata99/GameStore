namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Models.DownloadableContents;
    using GameStore.Services.DownloadableContents;
    using GameStore.Services.Games;
    using GameStore.Services.Sellers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class DownloadableContentsController : Controller
    {
        public readonly IGameService games;
        public readonly IDownloadableContentService dlcs;
        public readonly ISellerService sellers;

        public DownloadableContentsController(IDownloadableContentService dlcs, IGameService games,ISellerService sellers)
        {
            this.games = games;
            this.dlcs = dlcs;
            this.sellers = sellers;
        }

        [Authorize]
        public IActionResult All(int id)
        {
            var dlcsData = this.dlcs.GetDlcs(id);

            return View(dlcsData);
        }

        [Authorize]
        public IActionResult Add() => View(new DownloadableContentFormModel());

        
        [HttpPost]
        [Authorize]
        public IActionResult Add(int id, DownloadableContentFormModel dlc)
        {
            var sellerId = this.sellers.IdByUser(this.User.Id());

            var gameId = this.dlcs.GetGameId(id);

            if (!this.games.OwnedBySeller(gameId, sellerId) && !User.IsAdmin())
            {
                return Unauthorized();
            }

            this.dlcs.Create(dlc.Name,
                dlc.Price,
                dlc.ReleaseDate,
                dlc.ImageUrl,
                dlc.Description,
                id);

            return RedirectToAction("Details", "Games", new { id = id });
        }
        
        [Authorize]
        public IActionResult Edit(int id)
        {
            var dlcData = this.dlcs.GetDlc(id);
            
            var sellerId = this.sellers.IdByUser(this.User.Id());

            var gameId = this.dlcs.GetGameId(id);

            if (!this.games.OwnedBySeller(gameId, sellerId) && !User.IsAdmin())
            {
                return Unauthorized();
            }

            return View(new DownloadableContentFormModel
            {
                Name = dlcData.Name,
                Price = dlcData.Price,
                Description = dlcData.Description,
                ReleaseDate = dlcData.ReleaseYear,
                ImageUrl = dlcData.ImageURL
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, DownloadableContentFormModel dlc)
        {
            var sellerId = this.sellers.IdByUser(this.User.Id());

            var gameId = this.dlcs.GetGameId(id);

            if (!this.games.OwnedBySeller(gameId, sellerId) && !User.IsAdmin())
            {
                return Unauthorized();
            }

            this.dlcs.Edit(id,
                dlc.Name,
                dlc.Price,
                dlc.ReleaseDate,
                dlc.ImageUrl,
                dlc.Description);

            return RedirectToAction("All", "DownloadableContents", new { id = gameId });
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var sellerId = this.sellers.IdByUser(this.User.Id());

            var gameId = this.dlcs.GetGameId(id);

            if (!this.games.OwnedBySeller(gameId,sellerId) && !User.IsAdmin())
            {
                return Unauthorized();
            }

            this.dlcs.Delete(id);

            return RedirectToAction("All", "DownloadableContents", new { id = gameId });
        }
    }
}
