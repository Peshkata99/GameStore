namespace GameStore.Controllers
{
    using GameStore.Infrastructure;
    using GameStore.Models.Reviews;
    using GameStore.Services.Games;
    using GameStore.Services.Reviews;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ReviewsController : Controller
    {
        public readonly IReviewService reviews;
        public readonly IGameService games;

        public ReviewsController(IReviewService reviews,IGameService games)
        {
            this.games = games;
            this.reviews = reviews;
        }

        [Authorize]
        public IActionResult Add() => View(new ReviewFormModel());

        [HttpPost]
        [Authorize]
        public IActionResult Add(int id,ReviewFormModel review)
        {
            var userId = this.User.Id();

            this.reviews
                .Create(review.Content, review.StarCount, userId, id);

            return RedirectToAction("Details", "Games", new { id = id });
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            var userId = this.User.Id();

            var reviewData = this.reviews.GetReview(id);

            if (reviewData.UserId != userId && !User.IsAdmin())
            {
                return Unauthorized();
            }

            return View(new ReviewFormModel
            {
                Content = reviewData.Content,
                StarCount = reviewData.StarCount
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(int id, ReviewFormModel review)
        {
            var gameId = this.reviews.GetGameId(id);

            this.reviews.Edit(id, 
                review.Content,
                review.StarCount);

            return RedirectToAction("Details", "Games", new { id = gameId});
        }

        [Authorize]
        public IActionResult Delete(int id)
        {
            var userId = this.User.Id();

            var reviewData = this.reviews.GetReview(id);

            if (reviewData.UserId != userId && !User.IsAdmin())
            {
                return Unauthorized();
            }

            this.reviews.Delete(id);

            return RedirectToAction("Details", "Games", new { id = reviewData.GameId });
        }
    }
}
