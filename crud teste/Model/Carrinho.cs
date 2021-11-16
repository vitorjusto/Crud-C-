using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class Carrinho
    {
        public int IdCarrinho { get; set; }
        public float Desconto{ get; set; }


        public float precoDeCusto { get; set; }

        public float precoDeVenda { get; set; }

        public int quantidade { get; set; }
        public float PrecoBruto { get; set; }
        public float PrecoLiquido { get; set; }
        public int idVenda { get; set; }
        public int idProduto { get; set; }


    }
}
