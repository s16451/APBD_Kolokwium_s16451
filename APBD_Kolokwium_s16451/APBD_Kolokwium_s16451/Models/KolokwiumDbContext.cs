using APBD_Kolokwium_s16451.Configurations;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolokwium_s16451.Models
{
    public class KolokwiumDbContext : DbContext
    {
        public DbSet<Player> Player { get; set; }
        public DbSet<Player_Team> Player_Team { get; set; }
        public DbSet<Team> Team { get; set; }
        public DbSet<Championship_Team> Championship_Team { get; set; }
        public DbSet<Championship> Championship { get; set; }

        public KolokwiumDbContext() { }

        public KolokwiumDbContext(DbContextOptions options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamConfiguration());
            modelBuilder.ApplyConfiguration(new ChampionshipConfiguration());
            modelBuilder.ApplyConfiguration(new Player_TeamConfiguration());
            modelBuilder.ApplyConfiguration(new Championship_TeamConfiguration());
        }
    }
}
