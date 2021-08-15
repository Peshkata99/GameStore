namespace GameStore.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.Review;

    public class Review
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ContentMaxLength)]
        public string Content { get; set; }

        [Range(StarMinCount,StarMaxCount)]
        public int StarCount { get; set; }

        public DateTime PostedOn { get; set; }

        [Required]
        public string UserId { get; set; }

        public User User { get; set; }

        public int GameId { get; set; }

        public Game Game { get; set; }
    }
}
