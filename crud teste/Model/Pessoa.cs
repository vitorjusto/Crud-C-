using System;
using crud_teste.Model;
using System.Collections.Generic;



using System.Windows.Forms;
using System.Text.RegularExpressions;
using crud_teste.Validation;

namespace CRUD_teste.Model
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public string SobreNome { get; set; }


        public string Sexo { get; set; }

        public string DataDeNascimento { get; set; }

        public MyCPF CPF { get; set; }


        public Contato contato = new Contato();


        public Endereco endereco = new Endereco();

       

        public string nomeCompleto()
        {
            return this.Nome + this.SobreNome;
        }

        public void ValidarPessoa()
        {
            

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

       
    }
}
