using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Listagem
{
    public class RelatorioProdutosVendaListagem
    { 
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }

        public long Quantidade { get; set; }

        public MyDinheiro TotalBruto { get; set; }

        public MyDinheiro Desconto { get; set; }
        public MyDinheiro TotalLiquido { get; set; }
        public MyDinheiro TotalCusto { get; set; }

        public MyDinheiro TotalPrecoDeVenda { get; set; }

        public MyPorcento LucroEmPorcento { get => (( TotalPrecoDeVenda.GetAsDecimal() - TotalCusto.GetAsDecimal()) / TotalCusto.GetAsDecimal()) * 100; }
        public MyDinheiro LucroEmDinheiro { get => TotalPrecoDeVenda.GetAsDecimal() - TotalCusto.GetAsDecimal(); }

        public bool Ativo { get; set; }

        public RelatorioProdutosVendaListagem()
        {
            TotalBruto = new MyDinheiro();
            Desconto = new MyDinheiro();
            TotalLiquido = new MyDinheiro();
            TotalCusto = new MyDinheiro();
        }
    }
}
