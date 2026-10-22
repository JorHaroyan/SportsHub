
namespace SportsHub.Domain.Entities;

public class FootballMatches
{
    public Guid Id { get; set; }

    public Guid SportEventId { get; set; }
    public SportEvent SportEvent { get; set; } = null!;

    public Guid LeagueSeasonId { get; set; }
    public LeagueSeasons LeagueSeason { get; set; } = null!;

    public Guid HomeTeamId { get; set; }
    public Teams HomeTeam { get; set; } = null!;

    public Guid AwayTeamId { get; set; }
    public Teams AwayTeam { get; set; } = null!;

    public int HomeScore { get; set; }
    public int AwayScore { get; set; }

    public DateTime KickoffTime { get; set; }
    public string Status { get; set; } = string.Empty;
}
