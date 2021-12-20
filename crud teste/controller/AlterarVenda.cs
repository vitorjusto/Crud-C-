using crud_teste.DAO;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using static crud_teste.vieew.ListaDePedidos.ListagemDePedidos;

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
            ClienteDAO stmtpessoa = new ClienteDAO();
            ConexaoDAO stmtcolaborador = new ConexaoDAO();
            var venda = stmt.ConsultarVenda(id);

            venda.cliente = stmtpessoa.ConsultarCliente(venda.cliente.idCliente);

            venda.colaborador = stmtcolaborador.ConsultarColaborador(venda.colaborador.idColaborador);
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

        public List<PedidoListagem> Listar(pesquisar pesquisa)
        {

            var pedidos = stmt.ListarPedidos(pesquisa);
            return pedidos;
        }

        public List<Pedido_Produto> ListarProdutosDaVendas(DateTime dataInicial, DateTime dataFinal)
        {
            var resultado = stmt.ListarProdutosDaVendas(dataInicial, dataFinal);

            foreach (var item in resultado)
                item.produto = new AlterarProduto().Consultar(item.IdProduto);

            return resultado;
        }

        public List<VendaAPrazo> ListarVendaAPrazo()
        {
            var resultado = stmt.ListarVendaAPrazo();

            VendaDAO stmtvenda = new VendaDAO();
            ClienteDAO stmtCliente = new ClienteDAO();
            foreach(var item in resultado)
            {
                item.cliente = stmtCliente.ConsultarCliente(item.idCliente);
                item.Venda = stmtvenda.ConsultarVenda(item.idVenda);
                stmtCliente = new ClienteDAO();
                stmtvenda = new VendaDAO();
            }

            return resultado;
        }

        public List<VendaAPrazo> ListarVendaAPrazo(string pesquisa, string Tipo)
        {
            var resultado = stmt.ListarVendaAPrazo(pesquisa, Tipo);

            VendaDAO stmtvenda = new VendaDAO();
            ClienteDAO stmtCliente = new ClienteDAO();
            foreach (var item in resultado)
            {
                item.cliente = stmtCliente.ConsultarCliente(item.idCliente);
                item.Venda = stmtvenda.ConsultarVenda(item.idVenda);
                stmtCliente = new ClienteDAO();
                stmtvenda = new VendaDAO();
            }

            return resultado;
        }

        public VendaAPrazo PagarMeses(VendaAPrazo venda, int quantidade)
        {
            venda.mesesrestantes -= quantidade;
            venda.quantidaderestante = venda.mesesrestantes * venda.ValorPorMes.GetAsDecimal();
            if (venda.mesesrestantes == 0)
                venda.Pendente = false;
            stmt.PagarMeses(venda, quantidade);
            return venda;
        }
    }
}
