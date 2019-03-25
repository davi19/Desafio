using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Classes
{
    class EnvioEmail
    {
        public void Email(string corpo,string destinatario,string titulo)
        {

            MailMessage mensagem = new MailMessage("desafiocart@gmail.com", destinatario);
            mensagem.Subject = titulo;
            mensagem.Body = corpo;
            mensagem.IsBodyHtml = true;
            EnviaEmail(mensagem);
        }

        public void EnviaEmail(MailMessage mensagem)
        {
            Criptografia descriptador = new Criptografia();

            SmtpClient clienteEmail = new SmtpClient();
            clienteEmail.EnableSsl = true;
            clienteEmail.Port = 587;
            clienteEmail.DeliveryMethod = SmtpDeliveryMethod.Network;
            clienteEmail.UseDefaultCredentials = false;
            clienteEmail.Credentials = new NetworkCredential("desafiocart@gmail.com", descriptador.Descriptografa("oN6c0kGQhfl1BoQhyjlo5Q=="));
            clienteEmail.Host = "smtp.gmail.com";
            clienteEmail.Send(mensagem);
        }
    }
}
