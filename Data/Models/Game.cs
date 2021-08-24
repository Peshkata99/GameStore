namespace GameStore.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Game;

    public class Game
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Range(MinPrice,MaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DeveloperMaxLength)]
        public string Developer { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

        [Range(MinReleaseYear,MaxReleaseYear)]
        public int ReleaseYear { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public int SellerId { get; set; }

        public Seller Seller { get; set; }

        public IEnumerable<DownloadableContent> DownloadableContents { get; set; } = new List<DownloadableContent>();

        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}