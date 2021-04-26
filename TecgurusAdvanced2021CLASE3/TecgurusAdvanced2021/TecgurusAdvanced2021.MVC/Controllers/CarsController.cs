using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusAdvanced2021.MVC.DatabaseFirstExample;

namespace TecgurusAdvanced2021.MVC.Controllers
{
    public class CarsController : Controller
    {
      
        public ActionResult Index()
        {
            DBContextDatabaseFirst dBContext = new DBContextDatabaseFirst();

            //Lambda expression
            var cars = dBContext.Cars.Where(w=>w.Color=="Azul").ToList();

            //LINQ
            //Iqueryable es un tipo de intruccion que aun no va  ala BDD 
            var carsQuery = (from car in dBContext.Cars
                             where car.Color == "Azul"
                             select car).ToList();


            //consultar todos los alumnos el objeto es de tipo: List<Alumno>  ->> BDD Alumnos es mappeado por Entity Framework
            //Los datos vienen puros de la fuente de datos
            //Alumno contiene Id , Nombre , Appellido, ApellidoM , Edad

            //A nivel vista yo requiero que muestren El nombre completo "FullName" y la edad en una tabla de todos los alumnos 
            //
            //1.- cocatenacion 
            //AlumnoModel  



            return View();
        }
    }
}