using System;
using System.ComponentModel.DataAnnotations;

namespace GigHubNext.Models
{
    public class Gig
    {
        public int Id { get; set; }
        [Required]

        public GigUser Artist { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Genre Genre { get; set; }
    }
}