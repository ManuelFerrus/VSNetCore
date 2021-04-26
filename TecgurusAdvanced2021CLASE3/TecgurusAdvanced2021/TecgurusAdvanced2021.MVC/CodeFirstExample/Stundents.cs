using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC.CodeFirstExample
{
    public class Stundents
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(25)]
        public string FullName { get; set; }
        public string Email { get; set; }

        //promedio decimal

        //teacher con id nombre y edad
    }
}