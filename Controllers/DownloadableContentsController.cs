namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Models.DownloadableContents;
    using GameStore.Services.DownloadableContents;
    using GameStore.Services.Games;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class DownloadableContentsController : Controller
    {
        public readonly IGameService games;
        public readonly IDownloadableContentService dlcs;

        public DownloadableContentsController(IDownloadableContentService dlcs, IGameService games)
        {
            this.games = games;
            this.dlcs = dlcs;
        }

        [Authorize]
        public IActionResult All(int id)
        {
            return View();
        }

        [Authorize]
        public IActionResult Add() => View(new DownloadableContentFormModel());

        
        [HttpPost]
        [Authorize]
        public IActionResult Add(int id, DownloadableContentFormModel dlc)
        {
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
            var userId = this.User.Id();

            var dlcData = this.dlcs.GetDlc(id);

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
            var gameId = this.dlcs.GetGameId(id);

            this.dlcs.Edit(id,
                dlc.Name,
                dlc.Price,
                dlc.ReleaseDate,
                dlc.ImageUrl,
                dlc.Description);

            return RedirectToAction("Details", "Games", new { id = gameId });
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var gameId = this.dlcs.GetGameId(id);

            this.dlcs.Delete(id);

            return RedirectToAction("Details", "Games", new { id = gameId });
        }
    }
}
