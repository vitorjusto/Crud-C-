using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;

namespace crud_teste.Model
{
    class ClienteListagem
    {
        public int idcliente { get; set; }

        public string nomecompleto { get { return this.nome + "  " + this.sobrenome; } set { } }
        
        private string nome { get; set; }
        private string sobrenome { get; set; }
        public string Sexo { get; set; }

        


        public string DataDeNacimento { get; set; }


        private string Cidade { get; set; }
        private string UF { set; get; }

        private string logradouro { get; set; }

        private string bairro { get; set; }

        private int numero { get; set; }

        public string Endereço { get { return $"{this.Cidade} - {this.UF} \n Bairro: {this.bairro}  Rua: {this.logradouro}  Numero: {this.numero}"; } set { } }
        
        
        private string telefone { get; set; }
        
        private string celular { get; set; }
        private string email { get; set; }

        public string Contato { get { return $"{procurarContato()}"; } set { } }

        private string procurarContato()
        {
            if (new Regex(@"[0-9]{4} - [0-9]{4}").Match(this.telefone).Success)
                return this.telefone;
            else if (new Regex(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").Match(this.celular).Success)
                return this.celular;
            else
            {
                return this.email;
            }
        }
    }
}
