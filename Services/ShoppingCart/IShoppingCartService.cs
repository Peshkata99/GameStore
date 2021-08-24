namespace GameStore.Services.ShoppingCart
{
    using System.Collections.Generic;

    public interface IShoppingCartService
    {
        public IEnumerable<ShoppingCartItemServiceModel> GetUserShoppingCart(string userId);

        public int AddGame(int id,string userId);

        public int AddDlc(int id,string userId);

        public bool Remove(int id);

        public bool CheckOut(string userId);
    }
}
