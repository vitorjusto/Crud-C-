using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }

        public string CodigoDeBarras { get; set; }

        public string NomeDoProduto { get; set; }

        public MyDinheiro PrecoDeVenda = new MyDinheiro();


        public MyDinheiro PrecoDeCusto = new MyDinheiro();

        public long Estoque { get; set; }

        public bool Ativo { get; set; }

        public string Fabricante { get; set; }

        public Produto(Produto produto)
        {
            IdProduto = produto.IdProduto;

            CodigoDeBarras = produto.CodigoDeBarras;

            NomeDoProduto = produto.NomeDoProduto;

            PrecoDeCusto = produto.PrecoDeCusto.GetAsDecimal();

            PrecoDeVenda = produto.PrecoDeVenda.GetAsDecimal();

            Estoque = produto.Estoque;

            Ativo = produto.Ativo;

            Fabricante = produto.Fabricante;

        }

        public Produto()
        {

        }


    }
}
