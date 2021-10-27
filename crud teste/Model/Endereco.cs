using System.Text.RegularExpressions;
using System.Windows.Forms;
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


        public bool validarEndereco()
        {
            var valido = true;

            if(!new Regex(@"[0-9]{5}[-][0-9]{3}").Match(this.Cep).Success)
            {
                valido = false;
                MessageBox.Show("Digite um CEP Válido", "Atenção");
            }
            if (string.IsNullOrEmpty(this.Logradouro))
            {
                valido = false;
                MessageBox.Show("Campo Logradouro é obrigatório", "Atenção");
            }
            if (string.IsNullOrEmpty(this.Cidade))
            {
                valido = false;
                MessageBox.Show("Campo Cidade é obrigatório", "Atenção");
            }
            if (string.IsNullOrEmpty(this.UF))
            {
                valido = false;
                MessageBox.Show("Campo UF é obrigatório", "Atenção");
            }
            if(string.IsNullOrEmpty(this.Bairro))
            {
                valido = false;
                MessageBox.Show("Campo bairro é obrigatório");
            }


            return valido;
        }

    }
}
