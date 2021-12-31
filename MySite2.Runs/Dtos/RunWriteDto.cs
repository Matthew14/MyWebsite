using System;
using System.ComponentModel.DataAnnotations;

namespace MySite2.Runs.Dtos
{
    public class RunWriteDto
    {
        [Required]
        DateTime DateAndTime { get; set; }

        public string Location { get; set; }

        [Required]
        public float DistanceInKm { get; set; }
    }
}
