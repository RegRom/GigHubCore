﻿using System.ComponentModel.DataAnnotations;

namespace GigHubNext.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}