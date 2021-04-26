using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TecgurusAdvanced2021.MVC.Models
{
    public class PeliculaActorModel
    {
        public PeliculaModel Pelicula { get; set; }
        public ActorModel Actor { get; set; }
    }
}