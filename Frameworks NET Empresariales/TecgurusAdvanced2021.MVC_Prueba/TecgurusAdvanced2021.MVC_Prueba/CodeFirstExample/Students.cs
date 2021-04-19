using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC_Prueba.CodeFirstExample
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength (25)]
        public string Fullname{ get; set; }
        public string Email { get; set; }
        public decimal Promedio { get; set; }
    }
}