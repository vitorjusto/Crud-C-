using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Listagem
{
    public class PedidoListagem
    {
        public List<Carrinho> carrinhos = new List<Carrinho>();

        public Venda venda = new Venda();

        private string nomeColaborador { get; set; }

        private string SobrenomeColaborador { get; set; }


        private string nomeCliente { get; set; }
        
        private string sobrenomeCliente { get; set; }

        public string NomeCompletoCliente()
        {
            return nomeCliente + sobrenomeCliente;
        }

        public string NomeCompletoColaborador()
        {
            return nomeColaborador + SobrenomeColaborador;
        }
    }
}
