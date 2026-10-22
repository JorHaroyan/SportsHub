namespace SportsHub.Domain.Entities;

public class MmaFightStatistics
{
    public Guid Id { get; set; }

    public Guid MmaFightId { get; set; }
    public MmaFights MmaFight { get; set; } = null!;

    public Guid FighterId { get; set; }
    public Fighters Fighter { get; set; } = null!;

    public int? SignificantStrikesLanded { get; set; }
    public int? SignificantStrikesAttempted { get; set; }

    public int? TotalStrikesLanded { get; set; }
    public int? TotalStrikesAttempted { get; set; }

    public int? TakedownsLanded { get; set; }
    public int? TakedownsAttempted { get; set; }

    public int? SubmissionAttempts { get; set; }
    public int? ControlTimeSeconds { get; set; }
}