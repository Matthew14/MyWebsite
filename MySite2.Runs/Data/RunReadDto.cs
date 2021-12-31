using System;
using System.ComponentModel.DataAnnotations;

namespace MySite2.Runs.Data
{
    public class RunReadDto
    {

        [Key]
        public int Id { get; set; }

        [Required]
        DateTime DateAndTime { get; set; }

        public string Location { get; set; }

        [Required]
        public float DistanceInKm { get; set; }
    }
}
