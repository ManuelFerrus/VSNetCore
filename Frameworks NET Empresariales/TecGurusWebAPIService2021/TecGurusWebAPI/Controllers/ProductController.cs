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
    [RoutePrefix("api/product")] //se tiene que definir el prefijo
    public class ProductController : ApiController
    {
        ProductService productService = new ProductService();
        
        [HttpGet]
        [Authorize]
        [Route("GetAllProducts")]//se le da el alias al metodo
        public HttpResponseMessage Get()
        {
            var contentResult = GetAllProduct();
            var response = Request.CreateResponse(HttpStatusCode.OK);
            //Formato de codificacion de caracteres
            response.Content = new StringContent(contentResult, Encoding.UTF8, "application/json");
            return response;
        }

        private string GetAllProduct()
        {
            var products = productService.GetProducts();
            string outputString = JsonConvert.SerializeObject(products); //dio conflicto por el LazyLoading, por ende se modifica la entidad
            return outputString;
        }
    }
}
