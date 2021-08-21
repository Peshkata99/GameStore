namespace GameStore.Services.Games
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using GameStore.Models;
    using GameStore.Service.Games;
    using GameStore.Services.Reviews;
    using System.Collections.Generic;
    using System.Linq;

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

            var games = GetGames(gamesQuery)
                .Skip((currentPage - 1) * gamesPerPage)
                .Take(gamesPerPage);

            return new GameQueryServiceModel
            {
                TotalGames = totalGames,
                CurrentPage = currentPage,
                GamesPerPage = gamesPerPage,
                Games = games
            };
        }

        public int Create(string name, decimal price, string description, string developer, int releaseYear, string imageUrl, int genreId, int sellerId)
        {
            var gameData = new Game
            {
                Name = name,
                Price = price,
                Description = description,
                Developer = developer,
                ReleaseYear = releaseYear,
                ImageUrl = imageUrl,
                GenreId = genreId,
                SellerId = sellerId
            };

            this.data.Games.Add(gameData);
            this.data.SaveChanges();

            return gameData.Id;
        }

        public GameDetailsServiceModel Details(int id)
            => this.data
            .Games
            .Where(g => g.Id == id)
            .Select(g => new GameDetailsServiceModel
            {
                Id = id,
                Name = g.Name,
                Price = g.Price,
                Description = g.Description,
                Developer = g.Developer,
                ImageUrl = g.ImageUrl,
                ReleaseDate = g.ReleaseYear,
                GenreName = g.Genre.Name,
                SellerName = g.Seller.Name,
                SellerId = g.Seller.Id,
                UserId = g.Seller.UserId,
                Reviews = g.Reviews.Select
                    (r => new ReviewServiceModel
                    {
                        Id = r.Id,
                        Content = r.Content,
                        DisplayName = r.User.DisplayName,
                        PostedOn = r.PostedOn,
                        UserId = r.UserId
                     }).ToList()
            })
            .FirstOrDefault();
    
        public bool Delete(int id)
        {
            var gameData = this.data.Games.Find(id);

            if(gameData == null)
            {
                return false;
            }

            this.data.Games.Remove(gameData);

            this.data.SaveChanges();

            return true;
        }
            

        public bool Edit(int id, string name, decimal price, string description, string developer, int releaseYear, string imageUrl, int genreId)
        {
            var gameData = this.data.Games.Find(id);

            if(gameData == null)
            {
                return false;
            }

            gameData.Name = name;
            gameData.Price = price;
            gameData.Description = description;
            gameData.Developer = developer;
            gameData.ReleaseYear = releaseYear;
            gameData.ImageUrl = imageUrl;
            gameData.GenreId = genreId;

            this.data.SaveChanges();

            return true;
        }
        public bool GenreExists(int genreId) 
            => this.data
            .Genres
            .Any(g => g.Id == genreId);
        
        public IEnumerable<GameServiceModel> OwnedByUser(string userId)
            => GetGames(this.data
                .Games
                .Where(g => g.Seller.UserId == userId));

        public bool OwnedBySeller(int gameId, int sellerId)
            => this.data
                .Games
                .Any(g => g.Id == gameId && g.SellerId == sellerId);

        public IEnumerable<string> AllGenreNames()
            => this.data
                .Genres
                .Select(g => g.Name)
                .Distinct()
                .OrderBy(gr => gr)
                .ToList();

        public IEnumerable<GameGenreServiceModel> AllGameGenres()
            => this.data
                .Genres
                .Select(g => new GameGenreServiceModel
                {
                    Id = g.Id,
                    Name = g.Name
                })
                .ToList();
        private static IEnumerable<GameServiceModel> GetGames(IQueryable<Game> gameQuery)
            => gameQuery
                .Select(g => new GameServiceModel
                {
                    Id = g.Id,
                    Name = g.Name,
                    Price = g.Price,
                    ReleaseDate = g.ReleaseYear,
                    ImageUrl = g.ImageUrl,
                    GenreName = g.Genre.Name
                })
                .ToList();
    }
}
