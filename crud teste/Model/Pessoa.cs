
using crud_teste.Model;
using crud_teste.Model.Object_Values;
using System;

namespace CRUD_teste.Model
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }

        public string SobreNome { get; set; }


        public string Sexo { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public MyCPF CPF { get; set; }


        public Contato contato = new Contato();


        public Endereco endereco = new Endereco();

       public bool Ativo { get; set; }

        public string nomeCompleto()
        {
            return this.Nome + " " + this.SobreNome;
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
