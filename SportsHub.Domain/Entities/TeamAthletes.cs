using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class TeamAthletes
    {
        public Guid Id { get; set; }
        public Guid TeamId { get; set; }
        public Teams Team { get; set; } = null!;
        public Guid AthleteId { get; set; }
        public Athletes Athlete { get; set; } = null!;
        public DateOnly? JoinedAt { get; set; }
        public DateOnly? LeftAt { get; set; }
        public int? ShirtNumber { get; set; }
        public string? Position { get; set; } = string.Empty;
    }
}
