using System;
using crud_teste.Model;
using System.Collections.Generic;



using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CRUD_teste.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string SobreNome { get; set; }


        public string Sexo { get; set; }

        public string DataDeNascimento { get; set; }

        public string CPF { get; set; }

        public Contato contato = new Contato();


        public Endereco endereco = new Endereco();

       

        public string nomeCompleto()
        {
            return this.Nome + this.SobreNome;
        }

        public List<string> ValidarPessoa()
        {
            List<string> validacoes = new List<string>();
            DateTime.TryParse(this.DataDeNascimento, out DateTime data);
            if(!Testar_se_Nome_e_valido())
            {
                validacoes.Add("Preencha um nome valido");
            }
            if(!Testar_se_sexo_e_valido())
            {
                validacoes.Add("Campo Sexo obrigatório");

            }
            if(data.ToString() == "0")
            {
                validacoes.Add("Campo Data obrigatório");


            }
            if(!Testar_Se_CPF_E_Valido())
            {
                validacoes.Add("Digite um CPF válido");

            }

           validacoes.AddRange(endereco.validarEndereco());
            
            if (!contato.ValidarContato())
            {
                validacoes.Add("Digite Pelo menos um campo de contato");
                
            }


           


            return validacoes;

        }


        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa()
        {

        }

        public bool Testar_se_Nome_e_valido()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                return false;
            }
            return true;
        }

        public bool Testar_se_sexo_e_valido()
        {
            if (string.IsNullOrEmpty(this.Sexo))
            {
                return false;
            }
            return true;
        }

        public bool Testar_Se_CPF_E_Valido()
        {
            if (!string.IsNullOrEmpty(this.CPF))
                return new Regex(@"[0-9]{3}[,][0-9]{3}[,][0-9]{3}\-[0-9]{2}").Match(this.CPF).Success;
            else
                return false;
        }
    }
}
