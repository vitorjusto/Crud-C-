using System;
using System.Collections.Generic;
using crud_teste.DAO;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using CRUD_teste.Model;
using static crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos.RelatorioDoClientes;

namespace crud_teste.controller
{
    public class AlterarCliente
    {
        ClienteDAO stmt = new ClienteDAO();

        public Cliente consultarCliente(int id)
        {
            ClienteDAO stmt = new ClienteDAO();
            Cliente cliente = stmt.ConsultarCliente(id);
           
            return cliente;
        }

        public void SalvarCliente(Cliente cliente)
        {
            ClienteDAO stmt = new ClienteDAO();
            stmt.SalvarCliente(cliente);

        }

        public void excluir(Cliente cliente)
        {
            ClienteDAO stmt = new ClienteDAO();
            stmt.ExcluirCliente(cliente);
        }

        public void excluir(int id)
        {
            ClienteDAO stmt = new ClienteDAO();
            stmt.ExcluirCliente(id);
        }

        public int conectarComDAO(Cliente cliente)
        {
            ClienteDAO stmt = new ClienteDAO();
            var idCliente = stmt.GravarCliente(cliente);

            return idCliente;
            
        }

        public List<ClienteListagem> ListarCliente()
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.ListarCliente();
        }

        public List<ClienteListagem> ListarClientesAtivos()
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.ListarClienteAtivos();
        }

        public List<ClienteListagem> ListarCliente(string nome, string param)
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.ListarCliente(nome, param);
        }

        public List<ClienteListagem> ListarClienteAtivos(string nome, string param)
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.ListarClienteAtivos(nome, param);
        }

        public void AlterarAtivo(ClienteListagem cliente)
        {
            ClienteDAO stmt = new ClienteDAO();
            stmt.AlterarAtivo(cliente);
        }

        public List<RelatorioClienteListagem> RelatorioDeVenda()
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.RelatorioDeVenda();
        }

        public List<RelatorioClienteListagem> RelatorioDeVenda(Pesquisa pesquisa)
        {
            ClienteDAO stmt = new ClienteDAO();
            return stmt.RelatorioDeVenda(pesquisa);
        }
    }
}
