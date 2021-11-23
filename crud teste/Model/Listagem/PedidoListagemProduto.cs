using crud_teste.Model.Object_Values;
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



         public MyDinheiro TotalBruto
        {
            get; set;
        }
        public MyDinheiro TotalDeDesconto
        {

            get; set;
        }
        public MyDinheiro TotalLiquido
        {
            get; set;
        }

         public int IdVenda { get; set; }
         public int MesesAPrazo { get; set; }
         public string TipoDeVenda { get; set; }
         public int IdCliente { get; set; }
         public int IdColaborador { get; set; }
         public MyDinheiro DescontoAVIsta { get; set; }

        public string nomeColaborador { get; set; }

        public string SobrenomeColaborador { get; set; }


        public   string nomeCliente { get; set; }

        public string sobrenomeCliente { get; set; }

        public long QuantidadeUnitaria { get; set; }
        public long QuantidadeTotal { get; set; }

        public float TotalGasto()
        {
            float total = 0;
            foreach(var carrinho in carrinhos)
            {
                total += (float)carrinho.precoDeCusto.GetAsDouble() * carrinho.quantidade;
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
