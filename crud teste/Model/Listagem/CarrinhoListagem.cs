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
        public float Desconto { get; set; }

        public string NomeProduto { get; set; }

        public float PrecoDeVenda { get; set; }

        public int quantidade { get; set; }
        public float PrecoBruto { get; set; }
        public float PrecoLiquido { get; set; }
        public int idProduto { get; set; }
    }
}
