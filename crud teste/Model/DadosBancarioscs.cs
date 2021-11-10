using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class DadosBancarios
    {
        public int IdDadosBancarios { get; set; } 
        public string Banco { get; set; }

        public int Agencia { get; set; }

        public int Conta { get; set; }

        public int Digito { get; set; }


        public DadosBancarios()
        {

        }

        



    }
}
