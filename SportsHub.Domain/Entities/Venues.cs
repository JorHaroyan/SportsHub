using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Venues
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;
        public int? Capacity { get; set; }
        public ICollection<SportEvent> Events { get; set; } = new List<SportEvent>();
        public ICollection<Teams> Teams { get; set; } = new List<Teams>();
    }
}
