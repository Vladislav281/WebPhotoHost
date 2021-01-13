using System;
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
        public string PhotoPath { get; set; }
        [Required(ErrorMessage = "Please, write the description")]
        [MaxLength(50), MinLength(2)]
        public string Description { get; set; } 
        public Dept? Department { get; set; }
    }
   
}
