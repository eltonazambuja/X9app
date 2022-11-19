using AdvancedHMIControls;
using System;
using System.Net;
using System.Net.Mail;


namespace AdvancedHMICS.Libs
{
    internal class SendMsgPerson
    {
        public static int Send(Sender sender, string Para, string Assunto, string Conteudo )
        {
            try
            {
                SmtpClient smtpcliente = new SmtpClient(sender.GetServer(), sender.GetPort()); ;
                smtpcliente.EnableSsl = true;
                smtpcliente.UseDefaultCredentials = false;
                smtpcliente.Credentials = new NetworkCredential(sender.GetEmail(), sender.GetPass());

                MailMessage mensagem = new MailMessage();
                mensagem.From = new MailAddress("lactalis.ijui@outlook.com");
                mensagem.To.Add(Para);
                mensagem.Subject = Assunto;
                mensagem.IsBodyHtml = true;
                mensagem.Body = $"<h1>Registro de Acontecimento</h1><p></p><p>Email Teste</p><p>{DateTime.Now}</p><p>{Conteudo}</p>";
                smtpcliente.Send(mensagem);
                return 1;

            }
            catch (Exception)
            {
                return 0;
            }
            

        }
    }
}
