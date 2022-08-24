namespace FootballBetting.Data
{
    using FootballBetting.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class FootballBettingContext : DbContext
    {
        //Testing
        public FootballBettingContext()
        {

        }

        //For judge :)
        public FootballBettingContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }



        //Establish a connection to the SQL Server
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //True - connection string is already set
            //False - connection string isn't already set
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(Config.ConnectionString);
            }
        }

        // Define rules for creating Db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Composing PK of mapping entity

            modelBuilder
                .Entity<PlayerStatistic>(e =>
                {
                    //Configuration ot the current entity
                    //Define PK
                    e.HasKey(ps => new { ps.PlayerId, ps.GameId });
                });

            modelBuilder
                .Entity<Team>(e =>
                {
                    e
                     .HasOne(t => t.PrimaryKitColor)
                     .WithMany(c => c.PrimaryKitTeams)
                     .HasForeignKey(t => t.PrimaryKitColorId)
                     .OnDelete(DeleteBehavior.Restrict);

                    e
                     .HasOne(t => t.SecondaryKitColor)
                     .WithMany(c => c.SecondaryKitTeams)
                     .HasForeignKey(t => t.SecondaryKitColorId)
                     .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder
                .Entity<Game>(e =>
                {
                    e
                        .HasOne(g => g.HomeTeam)
                        .WithMany(t => t.HomeGames)
                        .HasForeignKey(g => g.HomeTeamId)
                        .OnDelete(DeleteBehavior.Restrict);

                    e
                        .HasOne(g => g.AwayTeam)
                        .WithMany(t => t.AwayGames)
                        .HasForeignKey(g => g.AwayTeamId)
                        .OnDelete(DeleteBehavior.Restrict);
                });

        }
    }
}
