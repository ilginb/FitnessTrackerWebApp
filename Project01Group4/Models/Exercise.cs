using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Equipment1 { get; set; }
        public int? Equipment2 { get; set; }
        public int? Equipment3 { get; set; }
        public int? Equipment4 { get; set; }
        public int? Equipment5 { get; set; }
        public int Type1 { get; set; }
        public int? Type2 { get; set; }
        public int? Type3 { get; set; }
        public int MuscleGroup1 { get; set; }
        public int? MuscleGroup2 { get; set; }

        public virtual Equipment Equipment1Navigation { get; set; }
        public virtual Equipment Equipment2Navigation { get; set; }
        public virtual Equipment Equipment3Navigation { get; set; }
        public virtual Equipment Equipment4Navigation { get; set; }
        public virtual Equipment Equipment5Navigation { get; set; }
        public virtual MuscleGroup MuscleGroup1Navigation { get; set; }
        public virtual MuscleGroup MuscleGroup2Navigation { get; set; }
        public virtual ExerciseType Type1Navigation { get; set; }
        public virtual ExerciseType Type2Navigation { get; set; }
        public virtual ExerciseType Type3Navigation { get; set; }
    }
}
