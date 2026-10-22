using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Sports
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public ICollection<SportEvent> Events { get; set; } = new List<SportEvent>();
    }
}
