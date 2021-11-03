using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using crud_teste.Model;
using CRUD_teste.Model;
namespace crud_teste.controller
{
    class AlterarCliente
    {
        public Cliente consultarCliente(int id)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            Cliente cliente = new Cliente();
            cliente = stmt.ConsultarCliente(id);
           
            return cliente;
        }

        public void SalvarCliente(Cliente cliente)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            stmt.SalvarCliente(cliente);

        }

        public void excluir(Cliente cliente)
        {

            ConexaoDAO stmt = new ConexaoDAO();
            stmt.ExcluirCliente(cliente);
        }

        public static int conectarComDAO(Cliente cliente)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            
            var idCliente = stmt.GravarCliente(cliente);


            return idCliente;
            
        }

        public List<ClienteListagem> ListarCliente()
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarCliente();
        }

        public List<ClienteListagem> ListarCliente(string nome, string param)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarCliente(nome, param);
        }
    }
}
