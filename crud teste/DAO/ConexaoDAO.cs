using System.Data.SqlClient;
using CRUD_teste.Model;

using Dapper;
using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        public void GravarCliente(Cliente cliente)
        {
            using ( con )
            {

                try
                {


                    con.Open();
                    var query = @"Insert Into Endereco(Cep, Logradouro, Cidade, UF, Complemento, Bairro, numero) OUTPUT INSERTED.idendereco Values(@Cep,@Logradouro,@Cidade,@UF, @Complemento, @Bairro, @Numero) ";
                    var idendereco = con.ExecuteScalar(query, cliente.endereco);
                   
                    query = @"Insert Into Contato(Email, telefone, DDI, Celular) OUTPUT INSERTED.idContato  Values(@Email,@Telefone,@DDI,@Celular)";
                    var idcontato = con.ExecuteScalar(query, cliente.contato);
                    
                    cliente.endereco.IdEndereco = int.Parse(idendereco.ToString());
                   cliente.contato.idContato = int.Parse(idcontato.ToString());

                    query = $@"Insert  Into  cliente(Nome, sobrenome, sexo, cpf, valorlimite, idendereco, datadenacimento, idcontato) OUTPUT INSERTED.idcliente Values(@Nome, @SobreNome, @Sexo, @CPF, @LimiteDeCompra, {cliente.endereco.IdEndereco}, @DataDeNascimento, {cliente.contato.idContato})";
                    con.ExecuteScalar(query, cliente);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();
            }
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
                colaborador.contato.Email = (string)reader["Email"];
                colaborador.contato.Telefone = (string)reader["telefone"];
                colaborador.contato.Celular = (string)reader["Celular"];
                colaborador.endereco.IdEndereco = (int)reader["idEndereco"];
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
                endereco.IdEndereco = (int)reader["idEndereco"];
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
                cliente.contato.Email = (string)reader["Email"];
                cliente.contato.Telefone = (string)reader["telefone"];
                cliente.contato.Celular = (string)reader["Celular"];
                cliente.endereco.IdEndereco = (int)reader["idEndereco"];
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
