using crud_teste.Model;
using System.Net.Mail;

namespace crud_teste.controller
{
    public class EnviarEmail
    {

        public static void EnviarEmailDeVenda(Venda venda)
        {


            MailMessage mail = new MailMessage();

            //define os endereços
            mail.From = new MailAddress("vitorhugojusto1@gmail.com");
            mail.To.Add("vitorhugojusto1@gmail.com");

            //define o conteúdo
            mail.Subject = "teste";
            mail.Body = "<h1>teste</h1>";
            mail.IsBodyHtml = true;

            //envia a mensagem
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("vitorhugojusto1@gmail.com", "");




            smtp.Send(mail);
        }

    }
}
