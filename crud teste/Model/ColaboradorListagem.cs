using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    class ColaboradorListagem
    {
        public int idColaborador { get; set; }
        public string nome { get; set; }

        public string sobrenome {get; set;}

        public string sexo { get; set; }

        public decimal salario { get; set; }

        public decimal PorcentagemDeComissao { get; set; }

       public string DataDeNascimento { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public string celular { get; set; }

        public string email { get; set; }
    }
}
