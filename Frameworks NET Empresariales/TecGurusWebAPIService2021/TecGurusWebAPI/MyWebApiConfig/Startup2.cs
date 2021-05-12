using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(TecGurusWebAPI.MyWebApiConfig.Startup2))]

namespace TecGurusWebAPI.MyWebApiConfig
{
    public class Startup2
    {
        //crea el token y permite los accesos
        //esta clase permite mediente configuracio
        public void Configuration(IAppBuilder app)
        {
            //se tiene que modificar el web.config y agregar la linea donde hacemos referencia a este documento
            //se pone el codigo en la myAuthorization
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll); //agregamos el nuget de microsoft.owin.cors
            
            var myProvider = new MyAuthorizationServerProvider();

            OAuthAuthorizationServerOptions options = new OAuthAuthorizationServerOptions
            {
                AllowInsecureHttp = true,
                //aqui defines la ruta para la creacion de token
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(365),
                Provider=myProvider
            };
            //aqui leo esos token
            app.UseOAuthAuthorizationServer(options);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            //los token viajan en los headers mediante el consumo
        }
    }
}
