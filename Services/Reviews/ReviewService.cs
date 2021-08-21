namespace GameStore.Services.Reviews
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReviewService : IReviewService
    {
        private readonly GameStoreDbContext data;

        public ReviewService(GameStoreDbContext data)
            => this.data = data;


        public int Create(string content, int starCount, string userId, int gameId)
        {
            var reviewData = new Review
            {
                Content = content,
                StarCount = starCount,
                UserId = userId,
                GameId = gameId,
                PostedOn = DateTime.UtcNow,
            };

            this.data.Reviews.Add(reviewData);
            this.data.SaveChanges();

            return reviewData.Id;
        }

        public bool Delete(int id)
        {
            var reviewData = this.data.Reviews.Find(id);

            if (reviewData == null)
            {
                return false;
            }

            this.data.Reviews.Remove(reviewData);
            this.data.SaveChanges();

            return true;
        }

        public bool Edit(int id, string content, int starCount)
        {
            var reviewData = this.data.Reviews.Find(id);

            if (reviewData == null)
            {
                return false;
            }

            reviewData.Content = content;
            reviewData.StarCount = starCount;

            this.data.SaveChanges();

            return true;
        }

        public Review GetReview(int id)
            => this.data.Reviews
                    .Find(id);

        public int GetGameId(int id)
            => this.data
            .Reviews
            .Find(id).GameId;

        public IEnumerable<ReviewServiceModel> AllReviews(int id)
            => this.data
            .Reviews
            .Select(r => new ReviewServiceModel 
            { 
                Content = r.Content,
                PostedOn = r.PostedOn,
                DisplayName = r.User.DisplayName,
                Id = r.Id,
                UserId = r.UserId
            });
    }
}
