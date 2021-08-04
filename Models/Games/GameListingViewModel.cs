﻿namespace GameStore.Models.Games
{
    public class GameListingViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public int ReleaseDate { get; set; }
    }
}