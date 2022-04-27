namespace GameStore.Services.Sellers
{
    public interface ISellerService
    {
        public bool IsSeller(string userId);

        public int IdByUser(string userId);

        public int AddSeller(string name, 
                             string phoneNumber, 
                             string userId);

    }
}