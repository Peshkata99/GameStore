namespace GameStore.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Game;

    public class ShoppingCartItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [Range(MinPrice, MaxPrice)]
        public decimal Price { get; set; }

        [Range(MinReleaseYear,MaxReleaseYear)]
        public int ReleaseDate { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
    }
}