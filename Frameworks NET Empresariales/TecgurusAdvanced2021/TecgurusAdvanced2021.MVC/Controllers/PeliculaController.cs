using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusAdvanced2021.MVC.Models;

namespace TecgurusAdvanced2021.MVC.Controllers
{
    public class PeliculaController : Controller
    {
        // GET: Pelicula
        public ActionResult Index()
        {
            return View("Peliculas");
        }

        public ViewResult IndexView()
        {
            return View("Peliculas");
            //esto no se puede regresar ya que no es una vista
            //return Content("<h1> <b> Hola desde MVC </b> </h1>");
        }

        public ContentResult GetContent()
        {
            return Content("<h1> <b> Hola desde MVC </b> </h1>");
        }

        public JsonResult GetJson()
        {
            var peliculas = getListPeliculas();
            return Json(peliculas, JsonRequestBehavior.AllowGet);
        }

        public FileResult GetFile()
        {
            //codigo para generar un archivo
            return null;
        }

        public ActionResult Suma()
        {
            int suma = 10 + 33;
            if (suma > 25)
            {
                return View("Index");
            }
            else
            {
                return Content("<h1> <b> La suma no es mayor a 10 </b> </h1>");
            }
        }

        //que es un modelo ? es un contenedor de datos, "un medodlo es una clase de C#"
        public ActionResult GetPelicula()
        {
            PeliculaModel pelicula = new PeliculaModel();
            pelicula.Id = 1;
            pelicula.Titulo = "Avengers";
            pelicula.Duracion = 158;
            pelicula.Genero = "Accion";
            return View("Pelicula", pelicula);
        }

        public ActionResult GetPeliculas()
        {
            var peliculas = getListPeliculas();
            return View("Pelicula", peliculas);
        }
        //Tarea mostrar 3 peliculasactormodel en una vista
        public ActionResult GetPeliculaActor()
        {
            PeliculaActorModel peliculaActorModel = new PeliculaActorModel();
            PeliculaModel pelicula = new PeliculaModel();
            ActorModel actor = new ActorModel();

            #region opcion1
            //peliculaActorModel.Pelicula.Id = 1;
            //peliculaActorModel.Pelicula.Titulo = "Avengers";
            //peliculaActorModel.Pelicula.Duracion = 158;
            //peliculaActorModel.Pelicula.Genero = "Accion";

            //peliculaActorModel.Actor.Id = 1;
            //peliculaActorModel.Actor.Nombre = "Jonhy Deep";
            //peliculaActorModel.Actor.Edad = 32;
            #endregion

            pelicula.Id = 1;
            pelicula.Titulo = "Avengers";
            pelicula.Duracion = 158;
            pelicula.Genero = "Accion";

            actor.Id = 1;
            actor.Nombre = "Jonhy Deep";
            actor.Edad = 32;

            peliculaActorModel.Pelicula = pelicula;
            peliculaActorModel.Actor = actor;
            return View("PeliculaActor", peliculaActorModel);
        }

        public List<PeliculaModel> getListPeliculas()
        {
            PeliculaModel peliculas1 = new PeliculaModel();
            PeliculaModel peliculas2 = new PeliculaModel();
            PeliculaModel peliculas3 = new PeliculaModel();

            //PeliculaModel peliculas4 = new PeliculaModel();
            //PeliculaModel peliculas5 = new PeliculaModel();
            //PeliculaModel peliculas6 = new PeliculaModel();
            //PeliculaModel peliculas7 = new PeliculaModel();
            //PeliculaModel peliculas8 = new PeliculaModel();

            peliculas1.Id = 1;
            peliculas1.Titulo = "EL increible Hulk";
            peliculas1.Duracion = 120;
            peliculas1.Genero = "Accion";

            peliculas2.Id = 2;
            peliculas2.Titulo = "Capitan america";
            peliculas2.Duracion = 180;
            peliculas2.Genero = "Accion";

            peliculas3.Id = 3;
            peliculas3.Titulo = "Iron Man";
            peliculas3.Duracion = 180;
            peliculas3.Genero = "Accion";

            List<PeliculaModel> peliculas = new List<PeliculaModel>();
            peliculas.Add(peliculas1);
            peliculas.Add(peliculas2);
            peliculas.Add(peliculas3);

            return peliculas;
        }

        public ActionResult GetPeliculasLinq()
        {
            var query = (from peliculas in getListPeliculas()
                         where peliculas.Duracion < 180
                         select peliculas).ToList();
            return View("Pelicula", query);
        }
        //Tarea mostrar 3 PeliculaActorModel en una vista
        public ActionResult ejercicio1()
        {
            return View("PeliculaActores", GetListPeliculaPrimeras3().ToList());
        }
        //public ActionResult()
        //{
        //    var list3Pelicualas = GetListPeliculaPrimeras3().ToList();
        //    var list5Pelicualas = GetListPeliculaPrimeras3().ToList();
        //}
        public List<PeliculaActorModel> GetListPeliculaPrimeras3()
        {
            PeliculaActorModel peliculaActorModel = new PeliculaActorModel();
            PeliculaModel pelicula = new PeliculaModel();
            ActorModel actor = new ActorModel();

            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        pelicula.Id = 1;
                        pelicula.Genero = "Comedia";
                        pelicula.Titulo = "Forest Gump";
                        pelicula.Duracion = 180;

                        actor.Id = 1;
                        actor.Nombre = "Tom Hanks";
                        actor.Edad = 63;

                        //peliculaActor.Pelicula = pelicula;
                        //peliculaActor.Actor = actor;
                        break;
                    case 1:
                        pelicula.Id = 2;
                        pelicula.Genero = "Accion";
                        pelicula.Titulo = "Club de la pelea";
                        pelicula.Duracion = 180;

                        actor.Id = 2;
                        actor.Nombre = "Brat Pitt";
                        actor.Edad = 47;

                        //peliculaActor.Pelicula = pelicula;
                        //peliculaActor.Actor = actor;
                        break;
                    case 2:
                        pelicula.Id = 3;
                        pelicula.Genero = "Accion";
                        pelicula.Titulo = "Transformers";
                        pelicula.Duracion = 120;

                        actor.Id = 3;
                        actor.Nombre = "Megan Fox";
                        actor.Edad = 31;

                        //peliculaActor.Pelicula = pelicula;
                        //peliculaActor.Actor = actor;
                        break;
                    default:
                        break;
                }
                peliculaActorModel.AddPeliculaActor(pelicula, actor);
            }
            var LstPeliculaActores = peliculaActorModel.GetPeliculaActorModels();
            return LstPeliculaActores;
        }

        //Agregen 5 pelicluas mas a la coleccion 2 drama , 2 terror , 1 suspenso , y 5 actores --> uno de ellos sea forzoso Will Smith 
        //Regresar a una vista todas peliculas donde la duracion sea mayor a 120 min y el genero sea accion
        //Regresar a una vista todas peliculas donde el genero sea Terror y ordenarlas descendentemente por titulo
        //Regresar a una vista todas las PeliculaActorModel donde la pelicula sea de genero drama o genero accion y el actor sea Will Smith

        //descargar e instalar postman

        public ActionResult viewBagExample()
        {
            //es un contenedor de informacion que vive en la solicitud
            //string, int, clases o modelos PeliculaModel
            //son de tipo dynamic
            ViewBag.Saludos = "Hola mundo";
            return View();
        }

        public ActionResult ViewBagDays()
        {
            List<string> lstDays = new List<string>();
            lstDays.Add("LUNES");
            lstDays.Add("MARTES");
            lstDays.Add("MIERCOLES");
            lstDays.Add("JUEVES");
            lstDays.Add("VIERNES");
            lstDays.Add("SABADO");
            lstDays.Add("DOMINGO");

            ViewBag.Dias = lstDays;
            return View();
        }
    }
}