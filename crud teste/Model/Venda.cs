using crud_teste.Model.Object_Values;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public MyDinheiro TotalBruto = new MyDinheiro();
        public MyDinheiro TotalDeDesconto = new MyDinheiro();
        public MyDinheiro TotalLiquido = 0;
        public int MesesAPrazo{ get; set; }
        public long QuantidadeDeTotal{ get; set; }
        public int QuantidadeUnitario{ get; set; }
        public string TipoDeVenda{ get; set; }

        public MyDinheiro DescontoAVIsta = new MyDinheiro();

        public List<Pedido_Produto> Pedido_Produto = new List<Pedido_Produto>();


        public int IdCliente { get; set; }

        public Cliente cliente = new Cliente();

        public int IdColaborador { get; set; }

        public Colaborador colaborador = new Colaborador();

       public void calcularTotalLiquido()
        {
            TotalLiquido = TotalBruto.GetAsDouble() - TotalDeDesconto.GetAsDouble();
        }


        public void AdicionarNaVenda(string formaDePagamento)
        {

            TipoDeVenda = formaDePagamento;

            QuantidadeUnitario = Pedido_Produto.Count();

            QuantidadeDeTotal = Pedido_Produto.Sum(x => x.quantidade);

            TotalBruto = Pedido_Produto.Sum(x => x.PrecoBruto.GetAsDouble());
            TotalLiquido = Pedido_Produto.Sum(x => x.PrecoLiquido.GetAsDouble()) - (TipoDeVenda.Equals("A vista") ? DescontoAVIsta.GetAsDouble() : 0.0);
            TotalDeDesconto = Pedido_Produto.Sum(x => x.Desconto.GetAsDouble());

        }

    }
}
