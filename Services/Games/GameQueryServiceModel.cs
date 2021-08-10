namespace GameStore.Services.Games
{
    using System.Collections.Generic;

    public class GameQueryServiceModel
    {
        public int CurrentPage { get; init; }

        public int GamesPerPage { get; init; }

        public int TotalGames { get; init; }

        public IEnumerable<GameServiceModel> Games { get; init; }
    }
}
