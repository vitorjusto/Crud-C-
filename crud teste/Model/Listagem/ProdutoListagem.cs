

namespace crud_teste.Model.Listagem
{
    public class ProdutoListagem
    {
        public int IdProduto { get; set; }
        public string nomeProduto { get; set; }

        public float PrecodeVenda { get; set; }

        public long Estoque { get; set; }
        public string fabricante { get; set; }


        public bool Ativo { get; set; }

    }
}
