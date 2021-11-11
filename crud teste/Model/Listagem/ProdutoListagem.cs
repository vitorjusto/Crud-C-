using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Listagem
{
    public class ProdutoListagem
    {
        public int IdProduto { get; set; }
        public string nomeProduto { get; set; }

        public float PrecodeVenda { get; set; }

        public float DescontoAVista { get; set; }

        public long Estoque { get; set; }
        public string fabricante { get; set; }


        public bool Ativo { get; set; }

    }
}
