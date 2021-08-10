namespace GameStore.Services.Games
{
    public class GameServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int ReleaseDate { get; set; }
    }
}
