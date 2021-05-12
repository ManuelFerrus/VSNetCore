using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TecGurusWebAPI.Controllers
{
    //se define un prefijo
    [RoutePrefix("api/data")]
    public class DataController : ApiController
    {
        [HttpGet]
        [Route("forall")] //Se pone un alias para el consumo de la URI
        public HttpResponseMessage Get()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Hola, la hora en el servidor es: " + DateTime.Now);
            return response;
        }

        [HttpGet]
        [Route("sumaNumeros")] //Se pone un alias para el consumo de la URI
        public HttpResponseMessage GetSuma(int num1, int num2)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            var suma = num1 + num2;
            response.Content = new StringContent("El total de la suma es : " + suma);
            return response;
        }
        [HttpGet]
        [Route("suma")] //Se pone un alias para el consumo de la URI
        public HttpResponseMessage Suma(int num1, int num2, int num3)
        {
            var response = Request.CreateResponse(HttpStatusCode.NoContent);
            var suma = num1 + num2 + num3;
            if (suma < 100)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest);
                response.Content = new StringContent("Suma menor a 100");
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK);
                response.Content = new StringContent("El total de la suma es : " + suma);
            }
            return response;
        }
        [HttpGet]
        [Authorize] //Se agrega para la autentificacion
        //[Authorize (Roles ="user")] //Se agrega para la autentificacion
        [Route("authenticate")] //Se pone un alias para el consumo de la URI
        public HttpResponseMessage GetForAuthenticate()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Estas autenticado");
            return response;
        }
        [HttpGet]
        //[Authorize] //Se agrega para la autentificacion
        //[Authorize] //Se agrega para la autentificacion
        [Authorize(Roles = "admin")] //Se agrega para la autentificacion
        [Route("Authorize")] //Se pone un alias para el consumo de la URI
        public HttpResponseMessage GetForAutorize()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Estas autorizado");
            return response;
        }
        
    }
}
