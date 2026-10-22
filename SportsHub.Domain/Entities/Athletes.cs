using System;
using System.Collections.Generic;
using System.Text;
using SportsHub.Domain.Enums;

namespace SportsHub.Domain.Entities
{
    public class Athletes
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public DateOnly? DateOfBirth { get; set; }
        public string? Nationality { get; set; } = string.Empty;
        public double? HeightCm { get; set; }
        public double? WeightKg { get; set; }
        public string? PhotoUrl { get; set; } = string.Empty;

        public ICollection<TeamAthletes> TeamAthletes { get; set; } = new List<TeamAthletes>();
        public ICollection<FootballMatchStatistics> footballMatchStatistics { get; set; } = new List<FootballMatchStatistics>();
        public Fighters? Fighter { get; set; }
    }
}
