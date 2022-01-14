using System;
using System.ComponentModel.DataAnnotations;

namespace MySite2.Runs.Models
{
    public class Run
    {
        [Key]
        public int Id { get; set; }

        [Required]
        DateTime DateAndTime { get; set; }

        public string Location { get; set; }

        [Required]
        public double DistanceInKm { get; set; }

    }
}
