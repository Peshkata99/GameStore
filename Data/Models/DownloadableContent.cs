namespace GameStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Game;

    public class DownloadableContent
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Required]
        [Range(MinPrice,MaxPrice)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(DlcDescriptionMaxLength)]
        public string Description { get; set; }

        public int ReleaseYear { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}