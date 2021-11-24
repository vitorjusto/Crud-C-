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
        private VendaDAO stmt = new VendaDAO();
        public void cadastrar(Venda venda)
        {

            stmt.cadastrar(venda);

        }


        public List<PedidoListagem> Listar()
        {
            
            var pedidos = stmt.ListarPedidos();
            return pedidos;
        }

        public Venda Consultar(int id)
        {
            ConexaoDAO stmtpessoa = new ConexaoDAO();
            var venda = stmt.ConsultarVenda(id);

            venda.cliente = stmtpessoa.ConsultarCliente(venda.cliente.idCliente);
            stmtpessoa = new ConexaoDAO();
            venda.colaborador = stmtpessoa.ConsultarColaborador(venda.colaborador.idColaborador);
            return venda;
        }

        public void aumentarEstoque(Pedido_Produto pedido)
        {

            stmt.reembolso(pedido);
        }

        public void ExcluirVenda(int id)
        {

            stmt.ExcluirVenda(id);

        }

        internal void SalvarProduto(Venda venda)
        {
            stmt.SalvarVenda(venda);
        }

        public void MudarAtivacao(Venda venda)
        {
            stmt.MudarAtivacao(venda);
        }
    }
}
