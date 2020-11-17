using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AccesoDatos
{
    public abstract class ServerCorreo
    {
        private SmtpClient smtpClient;
        protected string remitente { get; set; }
        protected string contrasena { get; set; }
        protected string host { get; set; }
        protected int puerto { get; set; }
        protected bool ssl { get; set; }

        //Metodo para inicializar el cliente SMTP
        protected void iniciarSmtpCliente()
        {
            smtpClient = new SmtpClient();
            //Especificacion de credenciales
            smtpClient.Credentials = new NetworkCredential(remitente, contrasena);
            smtpClient.Host = host;
            smtpClient.Port = puerto;
            smtpClient.EnableSsl = ssl;
        }

        //Metodo para enviar mensajes
        public void enviarCorreo(string asunto, string cuerpo, List<string> destinatario)
        {
            var mailMessage = new MailMessage();
            try
            {
                //Ingresamos el remitente
                mailMessage.From = new MailAddress(remitente);
                //ciclo con las direcciones de correo para destinatarios
                foreach (string mail in destinatario)
                {
                    //indicamos destinatario
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = asunto;
                mailMessage.Body = cuerpo;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //Deshechamos los objetos creados para liberar recursos
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
