using crud_teste.Model.Object_Values;

using System.Text.RegularExpressions;

namespace crud_teste.Model
{
    public class ClienteListagem
    {
        public int idcliente { get; set; }

        public int idPessoa { get; set; }

        public string nomecompleto { get { return this.nome + "  " + this.sobrenome; } set { } }
        
        private string nome { get; set; }
        private string sobrenome { get; set; }
        public string Sexo { get; set; }

        public string DataDeNascimento { get; set; }


        private string Cidade { get; set; }
        private string UF { set; get; }

        private string logradouro { get; set; }

        private string bairro { get; set; }

        private string numero { get; set; }

        public string Endereço { get { return $"{this.Cidade} - {this.UF} \n Bairro: {this.bairro}  Rua: {this.logradouro}  Numero: {this.numero}"; } set { } }
        
        
        private MyTelefone telefone { get; set; }
        
        private MyCelular celular { get; set; }
        private string email { get; set; }

        public string Contato { get { return $"{procurarContato()}"; } set { } }

        public bool Ativo { get; set; }

        private string procurarContato()
        {
            if (new Regex(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").Match(this.celular.RetornarCelularComFormatacao()).Success)
                return this.celular.RetornarCelularComFormatacao();
            else if (new Regex(@"[0-9]{4} - [0-9]{4}").Match(this.telefone.RetornarFormatado()).Success)
                return this.telefone.RetornarFormatado();
            
            else
            {
                return this.email;
            }
        }
    }
}
