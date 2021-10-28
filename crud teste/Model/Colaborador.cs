using System.Windows.Forms;
using System.Collections.Generic;
namespace CRUD_teste.Model
{
    public class Colaborador : Pessoa 
    {
        public int idColaborador { get; set; }

        public decimal PorcentagemDeComissao { get; set; }

        public string DadosBancarios { get; set; }
        public decimal Salario{ get; set; }

        

        public Colaborador() { }

        public List<string> ValidarColaborador()
        {
            List<string> validacoes = new List<string>();

            validacoes = ValidarPessoa();

            if(this.Salario <= 0)
            {
                validacoes.Add("Digite um salário valido");
            }

            return validacoes;
        }
    }
}
