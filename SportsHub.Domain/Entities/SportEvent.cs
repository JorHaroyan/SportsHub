using SportsHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class SportEvent
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Guid SportId { get; set; }
        public Sport Sport { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public EventStatus Status { get; set; } = EventStatus.Scheduled;
        public ICollection<EventParticipant> Participants { get; set; } = new List<EventParticipant>();
        public EventResult? Result { get; set; }

    }
}
