using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.Model;
using crud_teste.Model.Object_Values;

namespace CRUD_teste.Model
{
    public class Colaborador : Pessoa 
    {
        public int idColaborador { get; set; }

        public MyPorcento PorcentagemDeComissao { get; set; }

        public MyDinheiro comissao = new MyDinheiro();

        public DadosBancarios DadosBancarios = new DadosBancarios();
        public MyDinheiro Salario{ get; set; }

        

        public Colaborador() { }

       

        
    }
}
