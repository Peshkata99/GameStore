namespace GameStore.Services.ShoppingCart
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using System.Collections.Generic;
    using GameStore.Infrastructure;
    using System.Linq;

    public class ShoppingCartService : IShoppingCartService
    {
        private readonly GameStoreDbContext data;

        public ShoppingCartService(GameStoreDbContext data) =>
            this.data = data;


        public int AddGame(int id,string userId)
        {
            var gameData = this.data.Games.Find(id);

            var shoppingCartItemData = new ShoppingCartItem
            {
                Name = gameData.Name,
                Price = gameData.Price,
                ReleaseDate = gameData.ReleaseYear,
                ImageUrl = gameData.ImageUrl,
                UserId = userId
            };

            this.data.ShoppingCartItems.Add(shoppingCartItemData);
            this.data.SaveChanges();

            return shoppingCartItemData.Id;
        }

        public int AddDlc(int id, string userId)
        {
            var dlcData = this.data.DownloadableContents.Find(id);

            var shoppingCartItemData = new ShoppingCartItem
            {
                Name = dlcData.Name,
                Price = dlcData.Price,
                ReleaseDate = dlcData.ReleaseYear,
                ImageUrl = dlcData.ImageURL,
                UserId = userId
            };

            this.data.ShoppingCartItems.Add(shoppingCartItemData);
            this.data.SaveChanges();

            return shoppingCartItemData.Id;
        }



        public IEnumerable<ShoppingCartItemServiceModel> GetUserShoppingCart(string userId)
            => this.data
            .ShoppingCartItems
            .Where(sh => sh.UserId == userId)
            .Select(sh => new ShoppingCartItemServiceModel
            {
                Name = sh.Name,
                Price = sh.Price,
                ReleaseDate = sh.ReleaseDate,
                ImageUrl = sh.ImageUrl,
                Id = sh.Id
            });

        public bool Remove(int id)
        {
            var shoppingCartItemData = this.data.ShoppingCartItems.Find(id);

            if(shoppingCartItemData == null)
            {
                return false;
            }

            this.data.ShoppingCartItems.Remove(shoppingCartItemData);
            this.data.SaveChanges();

            return true;
        }

        public bool CheckOut(string userId)
        {
            var shoppingCartItemsData = this.data.ShoppingCartItems
                .Where(sh => sh.UserId == userId);

            if (shoppingCartItemsData == null)
            {
                return false;
            }

            this.data.RemoveRange(shoppingCartItemsData);
            this.data.SaveChanges();

            return true;
        }
    }
}