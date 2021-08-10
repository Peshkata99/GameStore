namespace GameStore.Models.Games
{
    using GameStore.Services.Games;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllGamesQueryModel
    {
        public const int GamesPerPage = 6;

        [Display(Name = "Search by text")]

        public string Genre { get; set; }

        public string SearchTerm { get; set; }

        public GameSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalGames { get; set; }

        
        public IEnumerable<string> Genres { get; set; }

        public IEnumerable<GameServiceModel> Games { get; set; }

        
    }
}
