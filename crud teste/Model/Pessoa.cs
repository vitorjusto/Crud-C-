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
        public int IdPessoa { get; set; }
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

        


        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa()
        {

        }

       
       
    }
}
