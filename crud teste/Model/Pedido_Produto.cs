using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class Pedido_Produto
    {
        public int IdCarrinho { get; set; }

        public MyDinheiro Desconto = new MyDinheiro();

        public Produto produto = new Produto();

        public MyDinheiro precoDeCusto = new MyDinheiro();

        public MyDinheiro precoDeVenda = new MyDinheiro();

        public int IdProduto { get; set; }

        public long quantidade { get; set; }
        public MyDinheiro PrecoBruto = new MyDinheiro();
        public MyDinheiro PrecoBrutoAtual
        {
            get => produto.PrecoDeVenda.GetAsDouble() * quantidade;
        }

        public MyDinheiro PrecoLiquido = new MyDinheiro();

        public MyDinheiro PrecoLiquidoAtual
        {
            get => PrecoBrutoAtual.GetAsDouble() - Desconto.GetAsDouble();
        }


        public int idVenda { get; set; }

        public long quantidadeRestante { get => produto.Estoque - quantidade; set { } }

        public Pedido_Produto()
        {

        }

        
        
        public Pedido_Produto(MyDinheiro desconto, MyDinheiro precoDeCusto, MyDinheiro precoDeVenda, long quantidade, MyDinheiro PrecoBruto, MyDinheiro PrecoLiquido, int idVenda, long quantidadeRestante)
        {
            this.Desconto = desconto;
            this.precoDeCusto = precoDeCusto.GetAsDouble();
            this.precoDeVenda = precoDeVenda.GetAsDouble();
            this.quantidade = quantidade;
            this.PrecoBruto = PrecoBruto.GetAsDouble();
            this.PrecoLiquido = PrecoLiquido.GetAsDouble();
            this.idVenda = idVenda;
            this.quantidadeRestante = quantidadeRestante;

        }

    }
}
