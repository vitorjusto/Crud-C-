using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
namespace CRUD_teste.Model
{
    public class Endereco
    {
         public  int IdEndereco { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int Numero { get; set; }

        public Endereco(int idEndereco, string cep, string logradouro, string cidade, string uF, string complemento, string bairro, int numero)
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


        public List<string> validarEndereco()
        {
            List<string> validacoes = new List<string>();

            if (!Validar_Se_CEP_E_Valido())
            {
                validacoes.Add("Campo CEP é obrigatório");
            }
            if (!Validar_Se_Logradouro_E_Valido())
            {
                validacoes.Add("Digite um logradouro válido");
            }
            if (!Validar_Se_Cidade_E_Valido())
            {
                validacoes.Add("Campo Cidade é obrigatório");
            }
            if (!Validar_Se_UF_E_Valido())
            {
                validacoes.Add("Campo UF é obrigatório");
            }
            if(string.IsNullOrEmpty(this.Bairro))
            {
                validacoes.Add("Campo bairro é obrigatório");
            }


            return validacoes;
        }

        public bool Validar_Se_CEP_E_Valido()
        {
            if (!string.IsNullOrEmpty(this.Cep))
                return new Regex(@"[0-9]{5}[-][0-9]{3}").Match(this.Cep).Success;
            else
                return false;
        }

        public bool Validar_Se_Logradouro_E_Valido()
        {
            if (string.IsNullOrEmpty(this.Logradouro))
                return false;
            else
                return true;
        }

        public bool Validar_Se_Cidade_E_Valido()
        {
            if (string.IsNullOrEmpty(this.Cidade))
                return false;
            else
                return true;
        }

        public bool Validar_Se_UF_E_Valido()
        {
            if (string.IsNullOrEmpty(this.UF))
                return false;
            else
                return true;
        }

        public bool Validar_Se_Bairro_E_Valido()
        {
            if (string.IsNullOrEmpty(this.Bairro))
                return false;
            else
                return new Regex(@"[a-zA-Z]+").Match(this.Bairro).Success; ;
        }
    }
}
