namespace GameStore.Models.Games
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Game;
    public class AddGameFormModel
    {
        [Required]
        [StringLength(NameMaxLength,MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [Range(MinPrice,MaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(DeveloperMaxLength, MinimumLength = DeveloperMinLength)]
        public string Developer { get; set; }

        [Required]
        [StringLength(
            int.MaxValue,
            MinimumLength = DescriptionMinLength,
            ErrorMessage = "The field Description must be a string with a minimum length of {2}")]
        public string Description { get; set; }

        [Display(Name = "Release Year")]
        [Required]
        [Range(MinReleaseYear, MaxReleaseYear)]
        public int ReleaseYear { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public IEnumerable<GameGenreViewModel> Genres { get; set; }
    }
}
