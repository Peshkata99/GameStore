namespace GameStore.Models.Games
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AllGamesQueryModel
    {
        public const int GamesPerPage = 6;

        public string Name { get; set; }

        [Display(Name = "Search by text")]
        public string SearchTerm { get; set; }

        public GameSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalGames { get; set; }
        public IEnumerable<string> Names { get; set; }

        public IEnumerable<GameListingViewModel> Games { get; set; }
    }
}
