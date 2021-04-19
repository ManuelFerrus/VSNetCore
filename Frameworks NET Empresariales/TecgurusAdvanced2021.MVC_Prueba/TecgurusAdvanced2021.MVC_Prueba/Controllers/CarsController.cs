using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecgurusAdvanced2021.MVC_Prueba.DatabaseFirstExample;

namespace TecgurusAdvanced2021.MVC_Prueba.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Index()
        {
            DBContextDatabaseFirt dBContext = new DBContextDatabaseFirt();
            var cars = dBContext.Cars.ToList();
            return View();
        }
    }
}