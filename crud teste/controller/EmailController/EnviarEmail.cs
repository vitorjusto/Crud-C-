using crud_teste.DAO;
using crud_teste.Model;
using System;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Security.Cryptography;

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
           

            foreach (var c in DecryptStringFromBytes(new DAOConfig().recuperarSenha(), 
                new byte[] { 21, 32, 53, 124, 45, 76, 47, 238, 59, 120, 131, 162, 183, 174, 165, 56, 97, 56, 48, 45, 222, 234, 123, 29, 78, 34, 23, 65, 67, 132, 131, 212 },
                new byte[] { 121, 22, 53, 47, 45, 69, 77, 85, 97, 160, 151, 212, 13, 4, 215, 160 }))
                    pasword.AppendChar(c);

            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("vitorhugojusto1@gmail.com", pasword);

            smtp.Send(mail);
        }

        static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            string plaintext = null;

            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.Zeros;

                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;
        }


        static byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            using (RijndaelManaged rijAlg = new RijndaelManaged())
            {
                rijAlg.Key = Key;
                rijAlg.IV = IV;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.Zeros;

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {

                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;

        }

    }
}
