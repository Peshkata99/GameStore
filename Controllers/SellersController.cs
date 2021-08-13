namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Models.Sellers;
    using GameStore.Services.Sellers;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class SellersController : Controller
    {
        private readonly ISellerService sellers;

        public SellersController(ISellerService sellers)
            => this.sellers = sellers;

        [Authorize]
        public IActionResult Become() => View();

        [HttpPost]
        [Authorize]
        public IActionResult Become(SellerFormModel seller)
        {
            var userId = this.User.Id();

            var userIdAlreadySeller = this.sellers.IsSeller(userId);

            if (userIdAlreadySeller)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(seller);
            }

            this.sellers.AddSeller(seller.Name, 
                              seller.PhoneNumber, 
                              userId);

            return RedirectToAction("All", "Games");
        }
    }
}
