namespace GameStore.Services.Reviews
{
    using GameStore.Data.Models;

    public interface IReviewService
    {
        public int Create(string content, 
            int starCount, 
            string userId, 
            int gameId);

        public bool Edit(int id, 
            string content, 
            int starCount);

        public bool Delete(int id);

        public Review GetReview(int id);

        public int GetGameId(int id);
    }
}
