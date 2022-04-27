namespace GameStore.Services.DownloadableContents
{
    using GameStore.Data.Models;
    using System.Collections.Generic;

    public interface IDownloadableContentService
    {
        public int Create(string name,
            decimal price,
            int releaseDate,
            string imageUrl,
            string description,
            int gameId);

        public bool Delete(int id);

        public bool Edit(int id,
            string name,
            decimal price,
            int releaseDAte,
            string imageUrl,
            string description);

        public DownloadableContent GetDlc(int id);

        public IEnumerable<DownloadableContentServiceModel> GetDlcs(int id);

        public int GetGameId(int id);
    }
}