using crud_teste.Model.Object_Values;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class VendaAPrazo
    {
        public int idVendaAPrazo { get; set; } 
        public int idVenda { get; set; } 
        public Venda Venda { get; set; } 
        public int idCliente { get; set; } 
        public Cliente cliente { get; set; } 

        public MyDinheiro ValorTotal { get; set; }
        public MyDinheiro ValorPorMes { get; set; }
        public int QuantidadeDeMeses { get; set; }

        public bool Pendente { get; set; }

        public int mesesrestantes { get; set; } 
        public MyDinheiro quantidaderestante { get; set; }

        public VendaAPrazo()
        {
            ValorTotal = new MyDinheiro();
            ValorPorMes = new MyDinheiro();

            quantidaderestante = new MyDinheiro();
    }

    }
}
