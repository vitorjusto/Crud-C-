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

        public string nomeColaborador { get; set; }

        public string SobrenomeColaborador { get; set; }


        public   string nomeCliente { get; set; }

        public string sobrenomeCliente { get; set; }


        public float TotalGasto()
        {
            float total = 0;
            foreach(var carrinho in carrinhos)
            {
                total += carrinho.precoDeCusto;
            }

            return total;
        }

        public float TotalReceita()
        {
            float total = 0;
            foreach(var carrinho in carrinhos)
            {
                total += carrinho.precoDeVenda;
            }

            return total;
        }
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
