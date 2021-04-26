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
        //Action Result es una accion generica puede regresar distintos resultados
        //Es la clase base para todos los resultados de acción de MVC
        public ActionResult Index()
        {
            //return View("Peliculas");

            return Content("<h1><b>Hola desde MVC</b></h1>");
        }


        public ViewResult IndexView()
        {
            return View("Peliculas");
            //este resultado no se puede regresar ya que no es una vista
            //return Content("<h1><b>Hola desde MVC</b></h1>");
        }

        public FileResult GetFile()
        {
            //Codigo para generar un archivo
            return null;
        }


        public ContentResult GetContent()
        {
            return Content("<h1><b>Hola desde MVC</b></h1>");
        }

        //Regresa un objeto Json
        public JsonResult getJson()
        {
            var peliculas = getListPeliculas();
            return Json(peliculas, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// En un Action result puedo regresar diferentes resultados
        /// dependiendo de mi logica de negocio "reglas" o proceso interno que requiera
        /// </summary>
        /// <returns></returns>
        public ActionResult Suma()
        {
            int suma = 10 + 33;
            if (suma > 25)
            {
                return View("Index");
            }
            else
            {
                return Content("<h1><b>La suma no es mayor a 10</b></h1>");
            }
        }

        //Que es un modelo ? es un contenedor de datos ,"un modelo es una clase en C#"
        //Clase PeliculaModel  en c#
        //Objeto pelicula cuando instancias una clase
        //Model es una clase pero sirve para llevar y obtener datos de una vista

        public ActionResult GetPelicula()
        {
            PeliculaModel pelicula = new PeliculaModel();
            pelicula.Id = 1;
            pelicula.Titulo = "Avengers";
            pelicula.Duracion = 160;
            pelicula.Genero = "Acción";
            return View("Pelicula", pelicula);

        }


        public ActionResult ViewBagExample()
        {
            //Es un contenedor de información que vive en la solicitud
            //Sting ,int ,long, Clases o modelos PeliculaModel
            ViewBag.Saludo = "Hola Mundo";
            return View();
        }

        public ActionResult ViewBagDays()
        {

            List<string> DaysList = new List<string> { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            ViewBag.Days = DaysList;
            //no utilizar un modelo, Si **Lista  en un ViewBag
            var model = getListPeliculas();
            // si apartir de una operacion regresa true
            ViewBag.Flag = true;

            return View(model);
        }



        public ActionResult GetPeliculaActor()
        {
            PeliculaActorModel peliculaActorModel = new PeliculaActorModel();
            PeliculaModel pelicula = new PeliculaModel();
            ActorModel actor = new ActorModel();
            pelicula.Id = 1;
            pelicula.Titulo = "Avengers";
            pelicula.Duracion = 160;
            pelicula.Genero = "Acción";
            actor.Id = 1;
            actor.Nombre = "Jony deep";
            actor.Edad = 32;
            peliculaActorModel.Pelicula = pelicula;
            peliculaActorModel.Actor = actor;
            return View("PeliculaActor", peliculaActorModel);

        }

        //crear una Accion "GetPeliculas" que regrese tres peliculas y las muestre en una vista 


        public ActionResult GetPeliculas()
        {
            var peliculas = getListPeliculas();
            return View("Peliculas", peliculas);
        }

        public List<PeliculaModel> getListPeliculas()
        {
            PeliculaModel pelicula1 = new PeliculaModel();
            pelicula1.Id = 1;
            pelicula1.Titulo = "Avengers";
            pelicula1.Duracion = 160;
            pelicula1.Genero = "Acción";

            PeliculaModel pelicula2 = new PeliculaModel();
            pelicula2.Id = 2;
            pelicula2.Titulo = "La vida es Bella";
            pelicula2.Duracion = 180;
            pelicula2.Genero = "Accion";

            PeliculaModel pelicula3 = new PeliculaModel();
            pelicula3.Id = 3;
            pelicula3.Titulo = "La llorona";
            pelicula3.Duracion = 180;
            pelicula3.Genero = "Accion";

            List<PeliculaModel> peliculas = new List<PeliculaModel>();
            peliculas.Add(pelicula1);
            peliculas.Add(pelicula2);
            peliculas.Add(pelicula3);
            return peliculas;
        }


        //Linq tecnologia de control de datos ---> excel, bloc de notas, sql, mysql, access, listas de c#
        //instrucciones complejas  para filtrado   lambda expression -->>> de preferencia no utilizarlo 
        public ActionResult GetPeliculasLinq()
        {
            var query = (from peliculas in getListPeliculas()
                         where peliculas.Duracion < 180
                         select peliculas).ToList();
            return View("Peliculas", query);

        }

        //Tarea mostrar 3 PeliculaActorModel en una vista

        //Agregen 5 pelicuas mas a la coleccion 2 drama , 2 terror , 1 suspenso , y 5 actores --> uno de ellos sea forzoso Will Smith 
        //Regresar a una vista todas peliculas donde la duracion sea mayor a 120 min y el genero sea accion
        //Regresar a una vista todas peliculas donde el genero sea Terror y ordenarlas descendentemente por titulo
        //Regresar a una vista todas las PeliculaActorModel donde la pelicula sea de genero drama o genero accion y el actor sea Will Smith

        //descargar e instalar postman

    }
}