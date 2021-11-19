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
        public List<Pedido_Produto> carrinhos = new List<Pedido_Produto>();

        public Venda venda = new Venda();

        public string nomeColaborador { get; set; }

        public string SobrenomeColaborador { get; set; }


        public   string nomeCliente { get; set; }

        public string sobrenomeCliente { get; set; }


        public float TotalGasto()
        {
            float total = 0;
            foreach(var carrinho in carrinhos)
            {
                total += (float)carrinho.precoDeCusto.GetAsDouble();
            }

            return total;
        }

        public float TotalReceita()
        {
            float total = 0;
            foreach(var carrinho in carrinhos)
            {
                total += (float)carrinho.precoDeVenda.GetAsDouble();
            }

            return total;
        }
        public string NomeCompletoCliente()
        {
            return $"{nomeCliente} {sobrenomeCliente}";
        }

        public string NomeCompletoColaborador()
        {
            return $"{nomeColaborador} {SobrenomeColaborador}";
        }
    }
}
