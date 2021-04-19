using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Tecgurus.ThreeLayers.Tools
{
    public static class MessageSender
    {

        public static void SendMessage(string to, string subject, string body)
        {

            var mail = new MailMessage
            {
                From = new MailAddress("epdc.dom@gmail.com"),
                Subject = subject,
                Body = body
            };
            mail.To.Add(new MailAddress(to));

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("edy.dev4@gmail.com", "D3v3l0p3r")
            };

            smtp.Send(mail);



        }

        public static void SendMessageConfigurationManager(string to, string subject, string body)
        {

            var mail = new MailMessage
            {
                From = new MailAddress(ConfigurationManager.AppSettings["mailuser"]),
                Subject = subject,
                Body = body
            };
            mail.To.Add(new MailAddress(to));

            using (var smtp = new SmtpClient
            {

                Host = ConfigurationManager.AppSettings["serverSmtp"],
                Port = Convert.ToInt32(ConfigurationManager.AppSettings["serverSmtpPort"]),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["mailUser"], ConfigurationManager.AppSettings["mailPass"])
            })
            {

                smtp.Send(mail);

            }
                     




        }

        

    }
}
