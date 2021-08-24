namespace GameStore.Models.DownloadableContents
{
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Game;

    public class DownloadableContentFormModel
    {
        [Required]
        [StringLength(NameMaxLength,MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Required]
        [Range(MinPrice, MaxPrice)]
        public decimal Price { get; set; }

        [Range(MinReleaseYear,MaxReleaseYear)]
        public int ReleaseDate { get; set; }

        [Display(Name = "Image URL")]
        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(DlcDescriptionMaxLength, 
            MinimumLength = DescriptionMinLength,
            ErrorMessage = "The field Description must be a string between {1} and {2} characters")]
        public string Description { get; set; }
    }
}
