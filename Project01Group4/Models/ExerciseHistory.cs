using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class ExerciseHistory
    {
        public int Id { get; set; }
        public int Person { get; set; }
        public int Exercise { get; set; }
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public decimal EnergyBurned { get; set; }
    }
}
