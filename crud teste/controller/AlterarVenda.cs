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
        public void cadastrar(Venda venda)
        {
            var stmt = new VendaDAO();
            stmt.cadastrar(venda);

        }


        public List<PedidoListagem> Listar()
        {
            var stmt = new VendaDAO();
            
            var pedidos = stmt.ListarPedidos();
            return pedidos;
        }

        public Venda Consultar(int id)
        {
            var stmt = new VendaDAO();
            ConexaoDAO stmtpessoa = new ConexaoDAO();
            var venda = stmt.ConsultarVenda(id);

            venda.cliente = stmtpessoa.ConsultarCliente(venda.IdCliente);
            stmtpessoa = new ConexaoDAO();
            venda.colaborador = stmtpessoa.ConsultarColaborador(venda.IdColaborador);
            return venda;
        }

        public void aumentarEstoque(Pedido_Produto pedido)
        {
            var stmt = new VendaDAO();
            stmt.reembolso(pedido);
        }
    }
}
