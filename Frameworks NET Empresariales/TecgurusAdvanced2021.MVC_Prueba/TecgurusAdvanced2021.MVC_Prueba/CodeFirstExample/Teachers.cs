using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC_Prueba.CodeFirstExample
{
    public class Teachers
    {
        [Key]
        public int TeacherId { get; set; }
        [Required]
        [StringLength(25)]
        public string Nombre{ get; set; }
        public int Edad { get; set; }
    }
}