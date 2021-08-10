namespace GameStore.Services.Games
{
    using System.Collections.Generic;
    using GameStore.Models.Games;

    public interface IGameService
    {
        GameQueryServiceModel All(
            string genre,
            string searchTerm,
            GameSorting sorting,
            int currentPage,
            int gamesPerPage);

        IEnumerable<string> AllGameGenres();
    }
}
