using SportsHub.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsHub.Domain.Entities
{
    public class Fighters
    {
        public Guid Id { get; set; }
        public Guid AthleteId { get; set; }
        public Athletes Athlete { get; set; } = null!;
        public double ReachCm { get; set; }
        public MmaWeightClass WeightClass { get; set; }
        public string? Stance { get; set; } = string.Empty;
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int NoContests { get; set; }
        public ICollection<MmaFights> FightsAsFighter1 { get; set; } = new List<MmaFights>();

        public ICollection<MmaFights> FightsAsFighter2 { get; set; } = new List<MmaFights>();

        public ICollection<MmaFights> FightsWon { get; set; } = new List<MmaFights>();

        public ICollection<MmaFightStatistics> Statistics { get; set; } = new List<MmaFightStatistics>();
    }
}
