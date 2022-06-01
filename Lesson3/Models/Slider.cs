﻿using System.ComponentModel.DataAnnotations;

namespace Lesson3.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:35)]
        public string Title1 { get; set; }
        [StringLength(maximumLength: 35)]
        public string Title2 { get; set; }
        [StringLength(maximumLength: 35)]

        public string Desc { get; set; }
        [StringLength(maximumLength: 250)]

        public string BtnText { get; set; }
        [StringLength(maximumLength: 35)]

        public string BtnUrl { get; set; }
        [StringLength(maximumLength: 100)]

        public string Image { get; set; }


    }
}
