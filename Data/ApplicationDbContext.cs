using HighscoresApp.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HighscoresApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Leaderboard> Leaderboards { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}