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
        public decimal Price { get; set; }
        [Required]
        [MaxLength(DeveloperMaxLength)]
        public string Developer { get; set; }
        [Required]
        public string Description { get; set; }
        public int ReleaseYear { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public IEnumerable<Genre> Genre { get; set; } = new List<Genre>();

        public IEnumerable<DownloadableContent> DownloadableContents { get; set; } = new List<DownloadableContent>();
    }
}
