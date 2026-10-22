using SportsHub.Domain.Enums;

namespace SportsHub.Domain.Entities;

public class FootballPlayerMatchStatistics
{
    public Guid Id { get; set; }

    public Guid AthleteId { get; set; }
    public Athletes Athlete { get; set; } = null!;

    public Guid FootballMatchId { get; set; }
    public FootballMatches FootballMatch { get; set; } = null!;

    public int MinutesPlayed { get; set; }
    public int Goals { get; set; }
    public int Assists { get; set; }

    public int YellowCards { get; set; }
    public int RedCards { get; set; }

    public int? Shots { get; set; }
    public int? ShotsOnTarget { get; set; }
    public PlayerPosition? Position { get; set; }
}
