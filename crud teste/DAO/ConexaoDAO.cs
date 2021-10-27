using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CRUD_teste.Model;

namespace crud_teste
{
    class ConexaoDAO
    {
        SqlConnection con = new SqlConnection();



        public ConexaoDAO()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
        }



        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }



        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public int GravarEndereco(string query)
        {

            SqlCommand command = new SqlCommand(query, con);
            return (int)command.ExecuteScalar();


        }

        public int GravarColaborador(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            return (int)command.ExecuteScalar();
        }

        public int GravarCliente(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            return (int)command.ExecuteScalar();
        }

        public Colaborador ConsultarColaborador(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            var reader = command.ExecuteReader();

            var colaborador = new Colaborador();


            reader.Read();

            using (reader)
            {
                colaborador.idColaborador = (int)reader["idColaborador"];
                colaborador.Nome = (string)reader["Nome"];
                colaborador.SobreNome = (string)reader["SobreNome"];
                colaborador.Sexo = (string)reader["Sexo"];
                colaborador.Salario = (decimal)reader["Salario"];
                colaborador.PorcentagemDeComissao = (decimal)reader["PorcentagemDeComissao"];
                colaborador.CPF = (string)reader["CPF"];
                colaborador.DadosBancarios = (string)reader["DadosBancários"];
                colaborador.Email = (string)reader["Email"];
                colaborador.Telefone = (string)reader["telefone"];
                colaborador.Celular = (string)reader["Celular"];
                colaborador.idEndereco = (int)reader["idEndereco"];
                colaborador.DataDeNascimento = (string)reader["DataDeNascimento"];


            }


            return colaborador;
        }

        public Endereco ConsultarEndereco(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            var reader = command.ExecuteReader();

            var endereco = new Endereco();


            reader.Read();

            using (reader)
            {
                endereco.Cep = (string)reader["Cep"];
                endereco.Logradouro = (string)reader["Logradouro"];
                endereco.Cidade = (string)reader["Cidade"];
                endereco.UF = (string)reader["UF"];
                endereco.Complemento = (string)reader["Complemento"];
                endereco.Bairro = (string)reader["Bairro"];
                endereco.Numero = (int)reader["numero"];


            }


            return endereco;
        }

        public Cliente ConsultarCliente(string query)
        {

            Cliente cliente = new Cliente();

            SqlCommand command = new SqlCommand(query, con);
            var reader = command.ExecuteReader();



            reader.Read();

            using (reader)
            {
                cliente.idCliente = (int)reader["idCliente"];
                cliente.Nome = (string)reader["Nome"];
                cliente.SobreNome = (string)reader["SobreNome"];
                cliente.Sexo = (string)reader["Sexo"];
                cliente.CPF = (string)reader["cpf"];
                cliente.Email = (string)reader["Email"];
                cliente.Telefone = (string)reader["telefone"];
                cliente.Celular = (string)reader["Celular"];
                cliente.idEndereco = (int)reader["idEndereco"];
                cliente.DataDeNascimento = (string)reader["DataDeNacimento"];
                cliente.LimiteDeCompra = (decimal)reader["ValorLimite"];


            }



            return cliente;



        }
        public void AlterarCliente(string query)
        {
            SqlCommand command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
        }
    }
}
