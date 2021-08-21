﻿namespace GameStore.Services.Reviews
{
    using GameStore.Data.Models;
    using System.Collections.Generic;

    public interface IReviewService
    {
        public IEnumerable<ReviewServiceModel> AllReviews(int id);

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
