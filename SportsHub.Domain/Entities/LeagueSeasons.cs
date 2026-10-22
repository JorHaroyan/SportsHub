using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class LeagueSeasons
    {
        public Guid Id { get; set; }
        public Guid LeagueId { get; set; }
        public Guid SeasonId { get; set; }
        public Leagues League { get; set; } = null!;
        public Seasons Season { get; set; } = null!;
        public ICollection<FootballMatches> FootballMatches { get; set; } = new List<FootballMatches>();
    }
}
