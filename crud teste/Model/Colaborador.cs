using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.Model;
using crud_teste.Model.Object_Values;

namespace CRUD_teste.Model
{
    public class Colaborador : Pessoa 
    {
        public int idColaborador { get; set; }

        public decimal PorcentagemDeComissao { get; set; }

        public MyDinheiro comissao = new MyDinheiro();

        public DadosBancarios DadosBancarios = new DadosBancarios();
        public decimal Salario{ get; set; }

        

        public Colaborador() { }

       

        
    }
}
