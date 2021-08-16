namespace GameStore.Services.Games
{
    using GameStore.Services.Reviews;
    using System.Collections.Generic;

    public class GameDetailsServiceModel : GameServiceModel
    {
        public string Developer { get; set; }

        public string Description { get; set; }

        public int GenreId { get; set; }

        public int SellerId { get; init; }

        public string SellerName { get; init; }

        public string UserId { get; init; }

        public IEnumerable<ReviewServiceModel> Reviews { get; set; }
    }
}
