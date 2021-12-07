using crud_teste.Model;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security;

namespace crud_teste.controller
{
    public class EnviarEmail
    {

        public static void EnviarEmailDeVenda(Venda venda)
        {
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("vitorhugojusto1@gmail.com");
            mail.To.Add(venda.cliente.contato.Email);

            var corpoDoEmail = File.ReadAllText("C:/Users/PC1/Desktop/Comitar Crud/crud teste/controller/EmailController/resposta_de_Agradecimento.html");

            corpoDoEmail = corpoDoEmail.Replace("{Nome_Do_Cliente}", venda.cliente.nomeCompleto());

            string produtos = "";
            var numProduto = 0;
            foreach(var produto in venda.Pedido_Produto)
            {
                produtos += $"<tr><td>{numProduto}</td><td>{produto.produto.NomeDoProduto}</td><td>{produto.precoDeVenda.GetAsString()}</td><td>{produto.quantidade}</td><td>{produto.PrecoBruto.GetAsString()}</td><td>{produto.Desconto.GetAsString()}</td><td>{produto.PrecoLiquido.GetAsString()}</td>";
                numProduto++;
            }
               
            corpoDoEmail = corpoDoEmail.Replace("{Listagem_Dos_Produtos}", produtos);




            string Totais = $"<tr><th>Totais Da Compra</th><th>{numProduto}</th><th>{venda.Pedido_Produto.Sum(x => x.precoDeVenda.GetAsDecimal()).ToString("C")}</th><th>{venda.QuantidadeDeTotal}</th><th>{venda.TotalBruto.GetAsString()}</th><th>{venda.TotalDeDesconto.GetAsString()}</th><th>{venda.TotalLiquido.GetAsString()}</th>";

            corpoDoEmail = corpoDoEmail.Replace("{Totais_da_Compra}", Totais);


            corpoDoEmail = corpoDoEmail.Replace("<th>", "<th style=\"border: 1px dashed black; padding: 17px; background-color:rgb(153, 221, 255);\">");
            corpoDoEmail = corpoDoEmail.Replace("<td>", "<td style=\"border: 1px dashed black; padding: 7px\">");


            corpoDoEmail = corpoDoEmail.Replace("{Tipo_DA_Compra}", venda.TipoDeVenda);
            corpoDoEmail = corpoDoEmail.Replace("{Nome_Do_Colaborador}", venda.colaborador.nomeCompleto());
            corpoDoEmail = corpoDoEmail.Replace("{Data_Da_Venda}", venda.DiaDaVenda.ToString("dd/MM/yyyy H:m"));

            mail.Subject = "Augustus Fashion";
            mail.Body = corpoDoEmail;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");


            SecureString pasword = new SecureString();



            for (int index = 0; index < File.ReadAllText("C:/Users/PC1/Desktop/C#/Segredo.txt").Length; index++)
                pasword.AppendChar(File.ReadAllText("C:/Users/PC1/Desktop/C#/Segredo.txt")[index]);
            pasword.MakeReadOnly();


            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("vitorhugojusto1@gmail.com", pasword);

            smtp.Send(mail);
        }

    }
}
