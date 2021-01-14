﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebPhotoHostL.Models
{
    public class Publication 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The name field cannot be null! Please, write the name")] // валидация
        [MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        [Required] // валидация
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Please, enter a Valid Email (format: example@exam.com)")]
        [MaxLength(50), MinLength(2)]
        public string Email { get; set; }
        public string PhotoPath { get; set; } 
        public Dept? Department { get; set; }
    }
   
}
