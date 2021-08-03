namespace GameStore.Infrastucture
{
    using System.Linq;
    using GameStore.Data;
    using GameStore.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection; 
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase( 
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<GameStoreDbContext>();

            data.Database.Migrate();

            SeedGenres(data);

            return app;
        }
        public static void SeedGenres(GameStoreDbContext data)
        {
            if (data.Genres.Any())
            {
                return;
            }

            data.Genres.AddRange(new[]{
                new Genre{ Name = "FPS"},
                new Genre{ Name = "Adventure"},
                new Genre{ Name = "RTS"},
                new Genre{ Name = "Visual Novel"},
                new Genre{ Name = "RPG"},
                new Genre{ Name = "MOBA"},
                new Genre{ Name = "Fighting"},
                new Genre{ Name = "MMO"},
                new Genre{ Name = "Survival"},
                new Genre{ Name = "Horror"},
                new Genre{ Name = "Simulation"},
                new Genre{ Name = "Turn-Based Strategy"},
                new Genre{ Name = "Sandbox"},
                new Genre{ Name = "Idle"},
                new Genre{ Name = "Racing"},
            });

            data.SaveChanges();
        }
    }
}
