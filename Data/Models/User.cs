namespace GameStore.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        public IEnumerable<Review> Reviews { get; set; } = new List<Review>();
    }
}
