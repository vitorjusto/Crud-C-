using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_teste.Model;
namespace crud_teste.controller
{
    class AlterarCliente
    {
        public Cliente consultarCliente(int id)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            stmt.conectar();
            Cliente cliente = new Cliente();

            cliente = stmt.ConsultarCliente($"Select * from Cliente where idCliente = {id}");
            cliente.endereco = stmt.ConsultarEndereco($"Select* from Endereco where idendereco = {cliente.endereco.IdEndereco}");
            
            stmt.desconectar();
            return cliente;
        }

        public void SalvarCliente(Cliente cliente)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.conectar();
            stmt.AlterarCliente($"update cliente set Nome = '{cliente.Nome}', Sobrenome = '{cliente.SobreNome}', sexo = '{cliente.Sexo}', DataDeNacimento = '{cliente.DataDeNascimento}', cpf = '{cliente.CPF}', Telefone = '{cliente.contato.Telefone}', Email = '{cliente.contato.Email}', Celular='{cliente.contato.Celular}' where idCliente = {cliente.idCliente}; ");
            stmt.AlterarCliente($"update endereco set CEP = '{cliente.endereco.Cep}', Logradouro = '{cliente.endereco.Logradouro}', Cidade = '{cliente.endereco.Cidade}', UF = '{cliente.endereco.UF}', Complemento= '{cliente.endereco.Complemento}', Bairro= '{cliente.endereco.Bairro}', Numero= '{cliente.endereco.Numero}' where idEndereco= {cliente.endereco.IdEndereco}; ");
            stmt.desconectar();

        }

        public void excluir(int id, int idEndereco)
        {

            ConexaoDAO stmt = new ConexaoDAO();
            stmt.conectar();
            stmt.AlterarCliente($"delete from Cliente where idCliente = {id}; ");
            stmt.AlterarCliente($"delete from Endereco where idEndereco = {idEndereco}");
            stmt.desconectar();
        }

        public static void conectarComDAO(Cliente cliente)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            
            stmt.GravarCliente(cliente);

               
            
            
        }
    }
}
