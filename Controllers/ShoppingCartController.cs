namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Services.ShoppingCart;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService shoppingCart;

        public ShoppingCartController(IShoppingCartService shoppingCart)
            => this.shoppingCart = shoppingCart;

        [Authorize]
        public IActionResult All()
        {
            var userId = this.User.Id();

            var userShoppingCart = this.shoppingCart.GetUserShoppingCart(userId);

            return View(userShoppingCart);
        }


        [Authorize]
        public IActionResult AddGame(int id)
        {
            var userId = this.User.Id();

            this.shoppingCart.AddGame(id, userId);

            return RedirectToAction("All", "ShoppingCart", new { id = userId });
        }

        [Authorize]
        public IActionResult AddDlc(int id)
        {
            var userId = this.User.Id();

            this.shoppingCart.AddDlc(id, userId);

            return RedirectToAction("All", "ShoppingCart", new { id = userId });
        }

        [Authorize]
        public IActionResult Remove(int id)
        {
            var userId = this.User.Id();

            this.shoppingCart.Remove(id);

            return RedirectToAction("All", "ShoppingCart", new { id = userId });
        }

        [Authorize]
        public IActionResult CheckOut()
        {
            var userId = this.User.Id();

            this.shoppingCart.CheckOut(userId);

            return RedirectToAction("All", "ShoppingCart", new { id = userId });
        }

    }
}