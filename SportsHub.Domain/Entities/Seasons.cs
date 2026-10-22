using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Seasons
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<LeagueSeasons> LeagueSeasons { get; set; } = new List<LeagueSeasons>();
    }
}
