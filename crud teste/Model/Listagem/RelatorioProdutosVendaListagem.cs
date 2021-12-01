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
        public string nomeProduto { get; set; }

        public long Quantidade { get; set; }

        public MyDinheiro TotalBruto { get; set; }

        public MyDinheiro Desconto { get; set; }
        public MyDinheiro TotalLiquido { get; set; }
        public MyDinheiro TotalCusto { get; set; }

        public MyPorcento LucroEmPorcento { get; set; }
        public MyDinheiro LucroEmDinheiro { get; set; }

        public RelatorioProdutosVendaListagem()
        {
            TotalBruto = new MyDinheiro();
            Desconto = new MyDinheiro();
            TotalLiquido = new MyDinheiro();
            TotalCusto = new MyDinheiro();
            LucroEmDinheiro = new MyDinheiro();
            LucroEmPorcento = new MyPorcento();
        }
    }
}
