using SportsHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class SportEvent
    {
        public Guid Id { get; set; }
        public Guid? VenueId { get; set; }
        public Venues? Venue { get; set; } = null!;
        public Guid SportId { get; set; }
        public Sports Sport { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public EventStatus Status { get; set; } = EventStatus.Scheduled;
        public string? Description { get; set; } = string.Empty;
        public FootballMatches? FootballMatch { get; set; }
    }
}
