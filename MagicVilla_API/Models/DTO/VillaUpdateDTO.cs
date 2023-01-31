﻿using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Models.DTO
{
    public class VillaUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public int Sqft { get; set; }
        [Required]
        public int Ocupancy { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        public string Amenity { get; set; }

    }
}
