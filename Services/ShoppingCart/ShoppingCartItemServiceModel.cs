namespace GameStore.Services.ShoppingCart
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants.Game;

    public class ShoppingCartItemServiceModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; }

        [Range(MinPrice, MaxPrice)]
        public decimal Price { get; set; }

        [Range(MinReleaseYear, MaxReleaseYear)]
        public int ReleaseDate { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public string UserId { get; set; }
    }
}