using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    class ClienteListagem
    {
        public int idcliente { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Sexo { get; set; }
        public string cpf { get; set; }
        
        public decimal ValorLimite { get; set; }
        public string DataDeNacimento { get; set; }
        public string Cidade { get; set; }
        public string UF { set; get; } 
        public string celular { get; set; }
        public string email { get; set; }
    }
}
