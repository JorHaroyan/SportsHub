using SportsHub.Domain.Enums;

namespace SportsHub.Domain.Entities;

public class MmaFights
{
    public Guid Id { get; set; }

    public Guid SportEventId { get; set; }
    public SportEvent SportEvent { get; set; } = null!;

    public Guid OrganizationId { get; set; }
    public MmaOrganizations Organization { get; set; } = null!;

    public Guid Fighter1Id { get; set; }
    public Fighters Fighter1 { get; set; } = null!;

    public Guid Fighter2Id { get; set; }
    public Fighters Fighter2 { get; set; } = null!;

    public Guid? WinnerId { get; set; }
    public Fighters? Winner { get; set; }

    public string? WeightClass { get; set; }
    public int ScheduledRounds { get; set; }

    public FightMethod? ResultMethod { get; set; }
    public int? EndingRound { get; set; }
    public TimeSpan? EndingTime { get; set; }

    public string? ResultDescription { get; set; }

    public ICollection<MmaFightStatistics> Statistics { get; set; } = new List<MmaFightStatistics>();
}