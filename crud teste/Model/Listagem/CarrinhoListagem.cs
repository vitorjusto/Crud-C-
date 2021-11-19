using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Listagem
{
    public class CarrinhoListagem
    {
        public int IdCarrinho { get; set; }
        public MyDinheiro Desconto = new MyDinheiro();

        public string NomeProduto { get; set; }

        public MyDinheiro PrecoDeVenda = new MyDinheiro();

        public long quantidade { get; set; }
        public MyDinheiro PrecoBruto = new MyDinheiro();
        public MyDinheiro PrecoLiquido = new MyDinheiro();
        public int idProduto { get; set; }
    }
}
