using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Cornershop.Models
{
    public class verificacionCorner
    {
        public void enviarVerificacion(string destino, string codigo)
        {
            string origen = "cornershopsoa@gmail.com";
            string password = "cornershopsoa1522250";
            string titulo = "Verificación Corner Shop";
            string cuerpo = "Su código de verificación es: "+codigo;
            MailMessage mail = new MailMessage(origen,destino,titulo,cuerpo);
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(origen,password);

            smtp.Send(mail);
            smtp.Dispose();
        }
    }
}