using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class MuscleGroup
    {
        public MuscleGroup()
        {
            ExerciseMuscleGroup1Navigations = new HashSet<Exercise>();
            ExerciseMuscleGroup2Navigations = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exercise> ExerciseMuscleGroup1Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseMuscleGroup2Navigations { get; set; }
    }
}
