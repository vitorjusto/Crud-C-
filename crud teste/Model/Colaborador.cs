using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.Model;

namespace CRUD_teste.Model
{
    public class Colaborador : Pessoa 
    {
        public int idColaborador { get; set; }

        public decimal PorcentagemDeComissao { get; set; }

        public DadosBancarios DadosBancarios = new DadosBancarios();
        public decimal Salario{ get; set; }

        

        public Colaborador() { }

       

        
    }
}
