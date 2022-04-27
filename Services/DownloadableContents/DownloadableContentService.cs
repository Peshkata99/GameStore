namespace GameStore.Services.DownloadableContents
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using System.Collections.Generic;
    using System.Linq;

    public class DownloadableContentService : IDownloadableContentService
    {

        private readonly GameStoreDbContext data;

        public DownloadableContentService(GameStoreDbContext data) 
            => this.data = data;

        public int Create(string name, decimal price, int releaseDate, string imageUrl, string description, int gameId)
        {
            var dlcData = new DownloadableContent
            {
                Name = name,
                Price = price,
                ReleaseYear = releaseDate,
                Description = description,
                ImageURL = imageUrl,
                GameId = gameId,
            };

            this.data.DownloadableContents.Add(dlcData);
            this.data.SaveChanges();

            return dlcData.Id;
        }

        public bool Delete(int id)
        {
            var dlcData = this.data.DownloadableContents.Find(id);

            if (dlcData == null)
            {
                return false;
            }

            this.data.DownloadableContents.Remove(dlcData);
            this.data.SaveChanges();

            return true;
        }

        public bool Edit(int id,string name, decimal price, int releaseDate, string imageUrl, string description)
        {
            var dlcData = this.data.DownloadableContents.Find(id);

            if (dlcData == null)
            {
                return false;
            }

            dlcData.Name = name;
            dlcData.Description = description;
            dlcData.Price = price;
            dlcData.ImageURL = imageUrl;
            dlcData.ReleaseYear = releaseDate;

            this.data.SaveChanges();

            return true;
        }

        public DownloadableContent GetDlc(int id)
            => this.data
            .DownloadableContents
                    .Find(id);

        public IEnumerable<DownloadableContentServiceModel> GetDlcs(int id)
            => this.data
            .DownloadableContents
            .Where(dlc => dlc.GameId == id)
            .Select(dlc => new DownloadableContentServiceModel
            {
                Name = dlc.Name,
                Price = dlc.Price,
                Description = dlc.Description,
                ReleaseDate = dlc.ReleaseYear,
                ImageUrl = dlc.ImageURL,
                Id = dlc.Id,
                GameId = dlc.GameId,
                UserId = dlc.Game.Seller.UserId
            });

        public int GetGameId(int id)
            => this.data
            .DownloadableContents
            .Find(id).GameId;
    }
}