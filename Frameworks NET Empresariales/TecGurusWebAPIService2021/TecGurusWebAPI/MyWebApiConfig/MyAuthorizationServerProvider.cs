using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.OAuth;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TecGurusWebAPI.MyWebApiConfig
{
    public class MyAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication (OAuthValidateClientAuthenticationContext context )
        {
            //el contexto es sobre la peticion
            context.Validated();
        }
        //Metodo donde configuro a que usuarios les puedo crear credenciales y validar token
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            //aqui es donde iriamos a validar que el usuario exista en la BD para generar el token
            //sirve para autentificar los servicios
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            if (context.UserName=="manuel" && context.Password=="manuel123")
            {
                //Le asignamos un rol
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim("username", "Ferrus"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Manuel"));
                context.Validated(identity);
            }
            else if (context.UserName=="admin" && context.Password=="admin123")
            {
                //Le asignamos un rol
                identity.AddClaim(new Claim(ClaimTypes.Role, "admin"));
                identity.AddClaim(new Claim("username", "Administrador"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Administrador"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username or passwrod is incorrect");
                return;
            }//regresamos a startup2
        }
    }
}