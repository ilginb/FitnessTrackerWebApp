using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class ExerciseType
    {
        public ExerciseType()
        {
            ExerciseType1Navigations = new HashSet<Exercise>();
            ExerciseType2Navigations = new HashSet<Exercise>();
            ExerciseType3Navigations = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exercise> ExerciseType1Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseType2Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseType3Navigations { get; set; }
    }
}
