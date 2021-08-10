namespace GameStore.Services.Games
{
    using System.Collections.Generic;
    using System.Linq;
    using GameStore.Data;
    using GameStore.Models.Games;

    public class GameService : IGameService
    {
        private readonly GameStoreDbContext data;

        public GameService(GameStoreDbContext data)
            => this.data = data;

        public GameQueryServiceModel All(
            string genre,
            string searchTerm,
            GameSorting sorting,
            int currentPage,
            int gamesPerPage)
        {

            var gamesQuery = this.data.Games.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genre))
            {
                gamesQuery = gamesQuery.Where(g => g.Genre.Name == genre);
            }

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                gamesQuery = gamesQuery.Where(g =>
                    (g.Name).ToLower().Contains(searchTerm.ToLower()) ||
                    g.Description.ToLower().Contains(searchTerm.ToLower()));
            }

            gamesQuery = sorting switch
            {
                GameSorting.ReleaseDate => gamesQuery.OrderByDescending(g => g.ReleaseYear),
                GameSorting.Genre => gamesQuery.OrderBy(g => g.Genre),
                GameSorting.DescendingPrice => gamesQuery.OrderByDescending(g => g.Price),
                GameSorting.AscendingPrice or _ => gamesQuery.OrderBy(g => g.Price)
            };

            var totalGames = gamesQuery.Count();

            var games = gamesQuery
                .Skip((currentPage - 1) * gamesPerPage)
                .Take(gamesPerPage)
                .Select(g => new GameServiceModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ReleaseDate = g.ReleaseYear,
                    ImageUrl = g.ImageUrl,
                })
                .ToList();

            return new GameQueryServiceModel
            {
                TotalGames = totalGames,
                CurrentPage = currentPage,
                GamesPerPage = gamesPerPage,
                Games = games
            };
        }

        public IEnumerable<string> AllGameGenres()
            => this.data
                .Genres
                .Select(g => g.Name)
                .Distinct()
                .OrderBy(gr => gr)
                .ToList();
    }
}
