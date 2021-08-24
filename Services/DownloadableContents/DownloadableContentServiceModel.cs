namespace GameStore.Services.DownloadableContents
{
    public class DownloadableContentServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int ReleaseDate { get; set; }

        public int GameId { get; set; }

        public string UserId { get; set; }
    }
}
