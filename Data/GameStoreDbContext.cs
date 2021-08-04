namespace GameStore.Data
{
    using GameStore.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class GameStoreDbContext : IdentityDbContext
    {
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<DownloadableContent> DownloadableContents { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Game>()
                .HasOne(g => g.Genre)
                .WithMany(gr => gr.Games)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<DownloadableContent>()
                .HasOne(dc => dc.Game)
                .WithMany(c => c.DownloadableContents)
                .HasForeignKey(dc => dc.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Genre>()
                .HasMany(gr => gr.Games)
                .WithOne(g => g.Genre)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}