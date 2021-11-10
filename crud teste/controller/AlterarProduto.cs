using crud_teste.DAO;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.controller
{
    class AlterarProduto
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
    }
}
