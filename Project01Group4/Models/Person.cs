using System;
using System.Collections.Generic;

#nullable disable

namespace Project01Group4.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Weight { get; set; }
        public int? Height { get; set; }
        public decimal? Bmi { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public int? RestingHeartRate { get; set; }
    }
}
