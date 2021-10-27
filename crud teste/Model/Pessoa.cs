using System;
using crud_teste.Model;



    
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

        public int idEndereco { get; set; }

        public Endereco endereco = new Endereco();

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string nomeCompleto()
        {
            return this.Nome + this.SobreNome;
        }

        public bool ValidarPessoa()
        {
            bool valido = true;
            DateTime.TryParse(this.DataDeNascimento, out DateTime data);
            if (string.IsNullOrEmpty(this.Nome))
            {
                valido = false;
                MessageBox.Show("Nome Inválido", "Atenção");
            }
            if(string.IsNullOrEmpty(this.Sexo))
            {
                valido = false;

                MessageBox.Show("O campo Sexo é obrigatório", "Atenção");
            }
            if(data.ToString() == "0")
            {
                valido = false;

                MessageBox.Show("O campo data é obrigatório", "Atenção");
            }
            if(!new Regex(@"[0-9]{3}[,][0-9]{3}[,][0-9]{3}\-[0-9]{2}").Match(this.CPF).Success)
            {
                valido = false;
                MessageBox.Show("Digite um CPF válido", "Atenção");
            }

            if (!endereco.validarEndereco())
            {
                valido = false;
            }

            if (!contato.ValidarContato())
            {
                valido = false;
                MessageBox.Show("É obrigatorio pelo menos um campo de contato");
            }


           


            return valido;

        }
    }
}
