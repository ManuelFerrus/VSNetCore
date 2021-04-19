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

        List<PeliculaActorModel> LstpeliculaActores = new List<PeliculaActorModel>();

        public PeliculaActorModel() { }
        public PeliculaActorModel(PeliculaModel pelicula, ActorModel actor)
        {
            this.Pelicula = pelicula;
            this.Actor = actor;
        }

        public void AddPeliculaActor(PeliculaModel pelicula, ActorModel actor)
        {
            LstpeliculaActores.Add(new PeliculaActorModel(pelicula, actor));
        }

        public List<PeliculaActorModel> GetPeliculaActorModels()
        {
            return LstpeliculaActores;
        }
    }
}