using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using TecGurusAdvanced.Services;

namespace TecGurusWebAPI.Controllers
{
    [RoutePrefix("api/category")] //se tiene que definir el prefijo
    public class CategoryController : ApiController
    {
        CategoryServices categoryServices = new CategoryServices();
        
        [HttpGet]
        [Authorize (Roles ="admin")]//rol de admin
        [Route("GetAllCategories")]//se le da el alias al metodo
        public HttpResponseMessage Get()
        {
            var contentResult = GetAllCategories();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            //Formato de codificacion de caracteres
            response.Content = new StringContent(contentResult, Encoding.UTF8, "application/json");
            return response;
        }

        private string GetAllCategories()
        {
            //obtener todas las categorias ordenadas por nombres
            var categories = categoryServices.GetCategories();
            string outputString = JsonConvert.SerializeObject(categories); //dio conflicto por el LazyLoading, por ende se modifica la entidad
            return outputString;
        }
    }
}
