namespace GameStore.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class GamesController : AdminController
    {
        public IActionResult Index() => View();
    }
}