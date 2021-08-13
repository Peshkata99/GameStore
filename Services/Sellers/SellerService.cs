namespace GameStore.Services.Sellers
{
    using System.Linq;
    using GameStore.Data;
    using GameStore.Data.Models;

    public class SellerService : ISellerService
    {
        private readonly GameStoreDbContext data;

        public SellerService(GameStoreDbContext data)
            => this.data = data;

        public bool IsSeller(string userId)
            => this.data
                .Sellers
                .Any(d => d.UserId == userId);

        public int IdByUser(string userId)
            => this.data
                .Sellers
                .Where(d => d.UserId == userId)
                .Select(d => d.Id)
                .FirstOrDefault();

        public int AddSeller(string name,string phoneNumber,string userId)
        {
            var sellerData = new Seller
            {
                Name = name,
                PhoneNumber = phoneNumber,
                UserId = userId
            };

            this.data.Sellers.Add(sellerData);
            this.data.SaveChanges();

            return sellerData.Id;
        }
    }
}
