using crud_teste.DAO;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using System.Collections.Generic;
using static crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos.RelatorioDosProdutos;

namespace crud_teste.controller
{
    public class AlterarProduto
    {
        public int Inserir(Produto produto)
        {
            var stmt = new DAOProduto();
            var id = stmt.Inserir(produto);

            return id;
        }

        public List<ProdutoListagem> Listar()
        {
            var stmt = new DAOProduto();
            var lista = stmt.Listar();

            return lista;
        }

        public List<ProdutoListagem> Listar(string pesquisa, string param)
        {
            var stmt = new DAOProduto();
            var lista = stmt.Listar(pesquisa, param);

            return lista;
        }

        public List<ProdutoListagem> ListarAtivos(string pesquisa, string param)
        {
            var stmt = new DAOProduto();
            var lista = stmt.ListarAtivo(pesquisa, param);

            return lista;
        }

        public Produto Consultar(int id)
        {
            var stmt = new DAOProduto();
            var produto = stmt.Consultar(id);
            return produto;
        }

        public void Salvar(Produto produto)
        {
            var stmt = new DAOProduto();
            stmt.Salvar(produto);
        }

        public void Excluir(int id)
        {
            var stmt = new DAOProduto();
            stmt.Excluir(id);
        }

        public List<ProdutoListagem> ListarAtivo()
        {
            var stmt = new DAOProduto();
            var lista = stmt.ListarAtivo();

            return lista;
        }

        public void AlterarAtivo(ProdutoListagem produto)
        {
            var stmt = new DAOProduto();
            stmt.AlterarAtivo(produto);
        }

        public void AlterarEstoque(int id, long estoque)
        {
            var stmt = new DAOProduto();
            stmt.AlterarEstoque(id, estoque);
        }


        public List<RelatorioProdutosVendaListagem> RelatorioDeVendaDosProdutos()
        {
            var stmt = new DAOProduto();
            var resultado = stmt.RelatorioDeVendaDosProdutos();

            return resultado;
        }


        public List<RelatorioProdutosVendaListagem> RelatorioDeVendaDosProdutos(pesquisar pesquisa )
        {
           
            var stmt = new DAOProduto();
            var resultado = stmt.RelatorioDeVendaDosProdutos(pesquisa);

            return resultado;
        }
    }
}
