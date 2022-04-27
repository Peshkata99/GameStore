namespace GameStore.Models.Reviews
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Review;
    public class ReviewFormModel
    {
        [Required]
        [StringLength(ContentMaxLength,MinimumLength = ContentMinLength)]
        public string Content { get; set; }
    }
}