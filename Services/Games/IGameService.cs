namespace GameStore.Services.Games
{
    using System.Collections.Generic;
    using GameStore.Models;
    using GameStore.Service.Games;

    public interface IGameService
    {
        GameQueryServiceModel All(
            string genre,
            string searchTerm,
            GameSorting sorting,
            int currentPage,
            int gamesPerPage);

        int Create(string name, 
            decimal price, 
            string description, 
            string developer, 
            int releaseYear, 
            string imageUrl, 
            int genreId, 
            int sellerId);

        bool Delete(int id);

        GameDetailsServiceModel Details(int id);

        bool Edit(int id,
            string name,
            decimal price,
            string description,
            string developer,
            int releaseYear,
            string imageUrl,
            int genreId);

        IEnumerable<GameServiceModel> OwnedByUser(string userId);
        bool OwnedBySeller(int gameId, int sellerId);

        bool GenreExists(int genreId);

        IEnumerable<string> AllGenreNames();

        IEnumerable<GameGenreServiceModel> AllGameGenres();
    }
}
