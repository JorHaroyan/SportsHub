
using Microsoft.EntityFrameworkCore;
using SportsHub.Domain.Entities;

namespace SportsHub.Infrastructure.Persistence;

public class SportsHubDbContext : DbContext
{
    public SportsHubDbContext(
        DbContextOptions<SportsHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<Sports> Sports => Set<Sports>();
    public DbSet<SportEvent> SportEvents => Set<SportEvent>();
    public DbSet<Venues> Venues => Set<Venues>();
    public DbSet<Athletes> Athletes => Set<Athletes>();
    public DbSet<Fighters> Fighters => Set<Fighters>();

    public DbSet<Teams> Teams => Set<Teams>();
    public DbSet<TeamAthletes> TeamAthletes => Set<TeamAthletes>();
    public DbSet<Leagues> Leagues => Set<Leagues>();
    public DbSet<Seasons> Seasons => Set<Seasons>();
    public DbSet<LeagueSeasons> LeagueSeasons => Set<LeagueSeasons>();

    public DbSet<FootballMatches> FootballMatches => Set<FootballMatches>();
    public DbSet<FootballMatchStatistics> FootballMatchStatistics
        => Set<FootballMatchStatistics>();
    public DbSet<FootballPlayerMatchStatistics>
        FootballPlayerMatchStatistics
        => Set<FootballPlayerMatchStatistics>();

    public DbSet<MmaOrganizations> MmaOrganizations
        => Set<MmaOrganizations>();
    public DbSet<MmaFights> MmaFights => Set<MmaFights>();
    public DbSet<MmaFightStatistics> MmaFightStatistics
        => Set<MmaFightStatistics>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Unique indexes
        modelBuilder.Entity<Sports>()
            .HasIndex(s => s.Name)
            .IsUnique();

        modelBuilder.Entity<Fighters>()
            .HasIndex(f => f.AthleteId)
            .IsUnique();

        modelBuilder.Entity<TeamAthletes>()
            .HasIndex(ta => new { ta.TeamId, ta.AthleteId })
            .IsUnique();

        modelBuilder.Entity<LeagueSeasons>()
            .HasIndex(ls => new { ls.LeagueId, ls.SeasonId })
            .IsUnique();

        modelBuilder.Entity<FootballPlayerMatchStatistics>()
            .HasIndex(ps => new { ps.FootballMatchId, ps.AthleteId })
            .IsUnique();

        modelBuilder.Entity<MmaFightStatistics>()
            .HasIndex(fs => new { fs.MmaFightId, fs.FighterId })
            .IsUnique();

        modelBuilder.Entity<FootballMatches>()
            .HasIndex(m => m.SportEventId)
            .IsUnique();


        // Relationships
        modelBuilder.Entity<Fighters>()
            .HasOne(f => f.Athlete)
            .WithOne(a => a.Fighter)
            .HasForeignKey<Fighters>(f => f.AthleteId);

        modelBuilder.Entity<FootballMatches>()
            .HasOne(m => m.HomeTeam)
            .WithMany(t => t.HomeMatches)
            .HasForeignKey(m => m.HomeTeamId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<FootballMatches>()
            .HasOne(m => m.AwayTeam)
            .WithMany(t => t.AwayMatches)
            .HasForeignKey(m => m.AwayTeamId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<FootballMatches>()
            .HasOne(m => m.SportEvent)
            .WithOne(e => e.FootballMatch)
            .HasForeignKey<FootballMatches>(m => m.SportEventId);

        modelBuilder.Entity<MmaFights>()
            .HasOne(f => f.Fighter1)
            .WithMany(a => a.FightsAsFighter1)
            .HasForeignKey(f => f.Fighter1Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MmaFights>()
            .HasOne(f => f.Fighter2)
            .WithMany(a => a.FightsAsFighter2)
            .HasForeignKey(f => f.Fighter2Id)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MmaFights>()
            .HasOne(f => f.Winner)
            .WithMany(a => a.FightsWon)
            .HasForeignKey(f => f.WinnerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MmaFightStatistics>()
            .HasOne(s => s.Fighter)
            .WithMany(f => f.Statistics)
            .HasForeignKey(s => s.FighterId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<MmaFights>()
            .HasOne(f => f.SportEvent)
            .WithMany()
            .HasForeignKey(f => f.SportEventId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<FootballMatchStatistics>()
            .Property(s => s.PossessionPercentage)
            .HasPrecision(5, 2);

        modelBuilder.Entity<FootballMatchStatistics>()
            .Property(s => s.PassAccuracy)
            .HasPrecision(5, 2);
    }
}
