namespace SportsHub.Domain.Entities;

public class FootballMatchStatistics
{
    public Guid Id { get; set; }

    public Guid FootballMatchId { get; set; }
    public FootballMatches FootballMatch { get; set; } = null!;

    public Guid TeamId { get; set; }
    public Teams Team { get; set; } = null!;

    public decimal? PossessionPercentage { get; set; }

    public int? TotalShots { get; set; }
    public int? ShotsOnTarget { get; set; }
    public int? ShotsOffTarget { get; set; }

    public int? Corners { get; set; }
    public int? Fouls { get; set; }
    public int? YellowCards { get; set; }
    public int? RedCards { get; set; }

    public decimal? PassAccuracy { get; set; }
}