using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Tecgurus.ThreeLayers.ExampleApp.Tools
{
    public class MessageSender
    {
        //configuraion de manera manual
        public void SendMessage(string to, string subject, string body)
        {
            try
            {
                //configuramos el cuerpo del correo
                var mail = new MailMessage
                {
                    From = new MailAddress("manuel.ferrus.developer@gmail.com"),
                    Subject = subject,
                    Body = body
                };
                //ponemos los destinatarios
                mail.To.Add(to);

                //se configura el cliente smpt
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587, //se puede cambiar al 25 - 26
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("manuel.ferrus.developer@gmail.com", "F3rrusquillita")
                };

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                //something happens
            }
        }
        public void SendMessageAppConfig(string to, string subject, string body)
        {
            //se agrega como referencia el systemconfiguration
            try
            {
                //configuramos el cuerpo del correo
                var mail = new MailMessage
                {
                    From = new MailAddress(ConfigurationManager.AppSettings["mailuser"]),
                    Subject = subject,
                    Body = body
                };
                //ponemos los destinatarios
                mail.To.Add(to);

                //se configura el cliente smpt
                var smtp = new SmtpClient
                {
                    Host = ConfigurationManager.AppSettings["serverSmpt"],
                    Port = Convert.ToInt32(ConfigurationManager.AppSettings["serverSmptPort"]), //se puede cambiar al 25 - 26
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(ConfigurationManager.AppSettings["mailUser"], ConfigurationManager.AppSettings["mailPass"])
                };

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                //something happens
            }
        }
    }
}
