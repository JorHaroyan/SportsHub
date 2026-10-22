using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Teams
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;
        public int? FoundedYear { get; set; }
        public Guid VenueId { get; set; }
        public Venues? Venue { get; set; }
        public string? LogoUrl { get; set; } = string.Empty;
        public ICollection<TeamAthletes> TeamAthletes { get; set; } = new List<TeamAthletes>();
        public ICollection<FootballMatches> HomeMatches { get; set; } = new List<FootballMatches>();
        public ICollection<FootballMatches> AwayMatches { get; set; } = new List<FootballMatches>();
    }
}
