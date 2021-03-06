﻿using System.ComponentModel.DataAnnotations;

namespace Education_Api_L1.Dtos.StudentDto
{
    public class StudentCreateDto
    {
        [Required]
        [MaxLength(300)]
        public string name { get; set; }

        [Required]
        [MaxLength(300)]
        public string family { get; set; }

        [MaxLength(11)]
        [MinLength(11)]
        public string phoneNumber { get; set; }

        [Required]
        public string Year_of_Birth { get; set; }
    }
}
