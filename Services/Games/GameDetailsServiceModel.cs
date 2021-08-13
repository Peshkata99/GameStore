namespace GameStore.Services.Games
{
    public class GameDetailsServiceModel : GameServiceModel
    {
        public string Developer { get; set; }

        public string Description { get; set; }

        public int GenreId { get; set; }

        public int SellerId { get; init; }

        public string SellerName { get; init; }

        public string UserId { get; init; }
    }
}
