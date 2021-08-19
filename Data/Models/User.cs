namespace GameStore.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using static DataConstants.User;

    public class User : IdentityUser
    {
        [Required]
        [MaxLength(NameMaxLength)]
        public string DisplayName { get; set; }

        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}
