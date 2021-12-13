using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            ExerciseEquipment1Navigations = new HashSet<Exercise>();
            ExerciseEquipment2Navigations = new HashSet<Exercise>();
            ExerciseEquipment3Navigations = new HashSet<Exercise>();
            ExerciseEquipment4Navigations = new HashSet<Exercise>();
            ExerciseEquipment5Navigations = new HashSet<Exercise>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Exercise> ExerciseEquipment1Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseEquipment2Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseEquipment3Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseEquipment4Navigations { get; set; }
        public virtual ICollection<Exercise> ExerciseEquipment5Navigations { get; set; }
    }
}
