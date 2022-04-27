namespace GameStore.Infrastructure
{
    using GameStore.Data;
    using GameStore.Data.Models;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using static Areas.Admin.AdminConstants;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder PrepareDatabase( 
            this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();

            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            SeedGenres(services);
            SeedAdministrator(services);

            return app;
        }
        public static void MigrateDatabase(IServiceProvider services)
        {
            var data = services.GetRequiredService<GameStoreDbContext>();

            data.Database.Migrate();
        }
        public static void SeedGenres(IServiceProvider services)
        {
            var data = services.GetRequiredService<GameStoreDbContext>();

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

        private static void SeedAdministrator(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task
                .Run(async () =>
                {
                    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
                    {
                        return;
                    }

                    var role = new IdentityRole { Name = AdministratorRoleName };

                    await roleManager.CreateAsync(role);

                    const string adminEmail = "admin@gss.com";
                    const string adminPassword = "admin12";

                    var user = new User
                    {
                        Email = adminEmail,
                        UserName = adminEmail
                    };

                    await userManager.CreateAsync(user, adminPassword);

                    await userManager.AddToRoleAsync(user, role.Name);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}