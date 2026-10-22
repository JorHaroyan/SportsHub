using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Leagues
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;
        public int? Tier { get; set; }
        public string? LogoUrl { get; set; }
        public ICollection<LeagueSeasons> LeagueSeasons { get; set; } = new List<LeagueSeasons>();
    }
}
