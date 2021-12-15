using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.Model;

namespace CRUD_teste.Model
{
    public class Endereco
    {
         public  int IdEndereco { get; set; }
        public MyCEP Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }

        public Endereco(int idEndereco, string cep, string logradouro, string cidade, string uF, string complemento, string bairro, string numero)
        {
            IdEndereco = idEndereco;
            Cep = cep;
            Logradouro = logradouro;
            Cidade = cidade;
            UF = uF;
            Complemento = complemento;
            Bairro = bairro;
            Numero = numero;
        }

        public Endereco()
        {

        }


    }
}
