using System.Windows.Forms;

namespace CRUD_teste.Model
{
    public class Colaborador : Pessoa 
    {
        public int idColaborador { get; set; }

        public decimal PorcentagemDeComissao { get; set; }

        public string DadosBancarios { get; set; }
        public decimal Salario{ get; set; }

        

        public Colaborador() { }

        public bool ValidarColaborador()
        {
            var valido = true;
            if(!ValidarPessoa())
            {
                valido = false;
            }

            if(this.Salario <= 0)
            {
                valido = false;
                MessageBox.Show("Digite um salario valido");
            }

            return valido;
        }
    }
}
