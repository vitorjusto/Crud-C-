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
    public class AlterarVenda
    {
        public void cadastrar(Venda venda, List<Carrinho> carrinho)
        {
            var stmt = new VendaDAO();
            stmt.cadastrar(venda, carrinho);

        }


        public List<PedidoListagem> Listar()
        {
            var stmt = new VendaDAO();
            
            var pedidos = stmt.ListarPedidos();
            return pedidos;
        }


    }
}
