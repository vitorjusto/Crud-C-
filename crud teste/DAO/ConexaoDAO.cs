using System.Data.SqlClient;
using CRUD_teste.Model;
using System.Collections.Generic;
using Dapper;
using System;
using crud_teste.Model;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace crud_teste
{
    class ConexaoDAO
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


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

        


        public int GravarCliente(Cliente cliente)
        {
            using (con)
            {




                con.Open();
                var tran = con.BeginTransaction();
                try
                {


                    var query = @"Insert Into Endereco(Cep, Logradouro, Cidade, UF, Complemento, Bairro, numero) OUTPUT INSERTED.idendereco Values(@Cep,@Logradouro,@Cidade,@UF, @Complemento, @Bairro, @Numero) ";
                    var idendereco = con.ExecuteScalar(query, cliente.endereco, tran);

                    query = @"Insert Into Contato(Email, telefone, DDI, Celular) OUTPUT INSERTED.idContato  Values(@Email,@Telefone,@DDI,@Celular)";
                    var idcontato = con.ExecuteScalar(query, cliente.contato, tran);

                    cliente.endereco.IdEndereco = int.Parse(idendereco.ToString());
                    cliente.contato.idContato = int.Parse(idcontato.ToString());
                    query = $@"Insert  Into  cliente(Nome, sobrenome, sexo, cpf, valorlimite, idendereco, datadenacimento, idcontato) OUTPUT INSERTED.idcliente Values(@Nome, @SobreNome, @Sexo, @CPF, @LimiteDeCompra, {cliente.endereco.IdEndereco}, @DataDeNascimento, {cliente.contato.idContato})";
                    cliente.idCliente = int.Parse(con.ExecuteScalar(query, cliente, tran).ToString());

                    tran.Commit();
                 }catch
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception();

                }

                con.Close();
                return cliente.idCliente;
            }
        }
        
        public Cliente ConsultarCliente(int id)
        {

            Cliente  cliente = new Cliente();
            using (con)
            {

                con.Open();
                var query = $"Select * from cliente where idCliente = {id}";
                var reader = con.ExecuteReader(query);
                reader.Read();
                using (reader)
                {
                    cliente.idCliente = (int)reader["idCliente"];
                    cliente.Nome = (string)reader["Nome"];
                    cliente.SobreNome = (string)reader["SobreNome"];
                    cliente.Sexo = (string)reader["Sexo"];
                    cliente.LimiteDeCompra = (decimal)reader["ValorLimite"];
                    cliente.CPF = (string)reader["CPF"];
                    cliente.endereco.IdEndereco = (int)reader["idEndereco"];
                    cliente.DataDeNascimento = (string)reader["DataDeNacimento"];
                    cliente.contato.idContato = (int)reader["idContato"];


                }
                query = $"select * from Endereco where idEndereco = {cliente.endereco.IdEndereco} ";
                reader = con.ExecuteReader(query);
                reader.Read();
                using (reader)
                {
                    cliente.endereco.Logradouro = (string)reader["Logradouro"];
                    cliente.endereco.UF = (string)reader["UF"];
                    cliente.endereco.Cep = (string)reader["CEP"];
                    cliente.endereco.Cidade = (string)reader["Cidade"];
                    cliente.endereco.Complemento = (string)reader["Complemento"];
                    cliente.endereco.Bairro = (string)reader["bairro"];
                    cliente.endereco.Numero = (int)reader["numero"];
                }

                query = $"select * from Contato where idcontato = {cliente.contato.idContato} ";
                reader = con.ExecuteReader(query);
                reader.Read();

                using (reader)
                {
                    cliente.contato.Email = (string)reader["email"];
                    cliente.contato.Telefone = (string)reader["telefone"];
                    cliente.contato.Celular = (string)reader["celular"];
                    cliente.contato.DDI = (string)reader["DDI"];
                }
            }
            return cliente;

        }
        public void SalvarCliente(Cliente cliente)
        {
            using (con)
            {

                con.Open();
                var tran = con.BeginTransaction();
                try
                {


                var query = @"update cliente set nome = @Nome where idcliente = @idCliente";
                con.Execute(query, cliente, tran);

                query = @"Update contato Set telefone = @Telefone, DDI= @DDI, Celular = @Celular Where idcontato = @idContato";
                con.Execute(query, cliente.contato, tran);

                query = @"Update endereco Set cep = @CEP, Logradouro = @Logradouro, cidade = @Cidade, UF = @UF, complemento = @Complemento, bairro = @Bairro, numero = @numero Where idendereco = @IdEndereco";
                con.Execute(query, cliente.endereco, tran);
                    tran.Commit();
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception(ex.Message);

                }
                con.Close();

            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
            con.Open();
            var tran = con.BeginTransaction();
            try
            {
            var query = $@"delete from cliente where idcliente = @idCliente";
            con.Execute(query,cliente , tran);

            query = $@"delete from endereco where idendereco = @IdEndereco";
            con.Execute(query,cliente.endereco, tran);

            query = $@"delete from contato where idcontato = @idContato";
            con.Execute(query,cliente.contato, tran);

           tran.Commit();
            }
            catch
            {
                tran.Rollback();

                con.Close();
                throw new Exception();

            }
            con.Close();
        }

        public List<ClienteListagem> ListarCliente()
        {
            using (con)
            {

                var query = @"select idcliente, Nome, SobreNome, Sexo, cpf, ValorLimite, DataDeNacimento, Cidade, UF, celular, email 
                               from cliente c Left outer join Endereco e on e.idEndereco = c.IdEndereco
                               Left outer join contato co on co.idContato = c.idContato;";
                var resultado = con.Query<ClienteListagem>(query);
                return resultado.ToList();

            }
        }

        public List<ClienteListagem> ListarCliente(string nome, string param)
        {
            using (con)
            {
                var queryWhere = "";
                if(param == "id")
                {
                    queryWhere = $"idcliente = {nome}";
                }
                else
                {
                    queryWhere = "Nome like '{nome}%'";
                }
                var query = $@"select idcliente, Nome, SobreNome, Sexo, cpf, ValorLimite, DataDeNacimento, Cidade, UF, celular, email 
                               from cliente c Left outer join Endereco e on e.idEndereco = c.IdEndereco
                               Left outer join contato co on co.idContato = c.idContato where {queryWhere} ;";
                var resultado = con.Query<ClienteListagem>(query);
                return resultado.ToList();

            }
        }

        public Colaborador ConsultarColaborador(int id)
        {
            Colaborador colaborador = new Colaborador();
            using (con)
            {

                con.Open();
                var query = $"Select * from colaborador where idColaborador = {id}";
                var reader = con.ExecuteReader(query);
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
                    colaborador.endereco.IdEndereco = (int)reader["idEndereco"];
                    colaborador.DataDeNascimento = (string)reader["DataDeNascimento"];
                    colaborador.contato.idContato = (int)reader["idContato"];


                }
                query = $"select * from Endereco where idEndereco = {colaborador.endereco.IdEndereco} ";
                reader = con.ExecuteReader(query);
                reader.Read();
                using (reader)
                {
                    colaborador.endereco.Logradouro = (string)reader["Logradouro"];
                    colaborador.endereco.UF = (string)reader["UF"];
                    colaborador.endereco.Cep = (string)reader["CEP"];
                    colaborador.endereco.Cidade = (string)reader["Cidade"];
                    colaborador.endereco.Complemento = (string)reader["Complemento"];
                    colaborador.endereco.Bairro = (string)reader["bairro"];
                    colaborador.endereco.Numero = (int)reader["numero"];
                }

                query = $"select * from Contato where idcontato = {colaborador.contato.idContato} ";
                reader = con.ExecuteReader(query);
                reader.Read();

                using (reader)
                {
                    colaborador.contato.Email = (string)reader["email"];
                    colaborador.contato.Telefone = (string)reader["telefone"];
                    colaborador.contato.Celular = (string)reader["celular"];
                    colaborador.contato.DDI = (string)reader["DDI"];
                }
            }
            return colaborador;
        }

        public int GravarColaborador(Colaborador colaborador)
        {

            using (con)
            {

                con.Open();
                var tran = con.BeginTransaction();
                try
                {
                var query = @"Insert Into Endereco(Cep, Logradouro, Cidade, UF, Complemento, Bairro, numero) OUTPUT INSERTED.idendereco Values(@Cep,@Logradouro,@Cidade,@UF, @Complemento, @Bairro, @Numero) ";
                var idendereco = con.ExecuteScalar(query, colaborador.endereco, tran);

                query = @"Insert Into Contato(Email, telefone, DDI, Celular) OUTPUT INSERTED.idContato  Values(@Email,@Telefone,@DDI,@Celular)";
                var idcontato = con.ExecuteScalar(query, colaborador.contato, tran);

                colaborador.endereco.IdEndereco = int.Parse(idendereco.ToString());
                colaborador.contato.idContato = int.Parse(idcontato.ToString());

                query = $@"Insert  Into Colaborador(Nome, Sobrenome, Sexo, Salario, PorcentagemDeComissao, CPF, DadosBancários, idEndereco, DataDeNascimento, idContato) OUTPUT INSERTED.idcolaborador Values(@Nome, @SobreNome, @Sexo, @Salario, @PorcentagemDeComissao, @CPF, @DadosBancarios, {colaborador.endereco.IdEndereco}, @DataDeNascimento, {colaborador.contato.idContato})";
                colaborador.idColaborador = int.Parse(con.ExecuteScalar(query, colaborador, tran).ToString());

                tran.Commit();
                }
                catch
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception();

                }


                con.Close();
                return colaborador.idColaborador;
            }
        }

        public void SalvarColaborador(Colaborador colaborador)
        {
            using (con)
            {


                con.Open();
                var tran = con.BeginTransaction();
                try
                {

                var query = @"update colaborador set nome = @nome , sobrenome = @SobreNome, sexo = @sexo, cpf = @CPF, DataDeNascimento = @DataDeNascimento, salario = @Salario, porcentagemDecomissao = @PorcentagemDeComissao, dadosbancários = @DadosBancarios  where idColaborador = @idColaborador";
                con.Execute(query, colaborador, tran);

                query = @"update contato set telefone = @Telefone, DDI= @DDI, Celular = @Celular where idcontato = @idContato";
                con.Execute(query, colaborador.contato, tran);

                query = @"update endereco set cep = @CEP, Logradouro = @Logradouro, cidade = @Cidade, UF = @UF, complemento = @Complemento, bairro = @Bairro, numero = @numero where idendereco = @IdEndereco";
                con.Execute(query, colaborador.endereco, tran);
                tran.Commit();
                }
                catch
                {
                tran.Rollback();
                con.Close();
                throw new Exception();
                }
            con.Close();

            }
        }

        public void ExcluirColaborador(Colaborador colaborador)
        {
            con.Open();

            var tran = con.BeginTransaction();
            try
            {

            var query = $@"delete from colaborador where idcolaborador = @idColaborador";
            con.Execute(query, colaborador, tran);

            query = $@"delete from endereco where idendereco = @IdEndereco";
            con.Execute(query, colaborador.endereco, tran);

            query = $@"delete from contato where idcontato = @idContato";
            con.Execute(query, colaborador.contato, tran);

            tran.Commit();
            }
            catch
            {
                tran.Rollback();
                con.Close();
                throw new Exception();
            }
        con.Close();
        }

        public List<ColaboradorListagem> ListarColaboradores()
        {

            using (con)
            {

                var query = @"select idcolaborador, Nome, SobreNome, Sexo, Salario, PorcentagemDeComissao, DataDeNascimento, Cidade, UF, celular, email 
                               from Colaborador c Left outer join Endereco e on e.idEndereco = c.IdEndereco
                               Left outer join contato co on co.idContato = c.idContato;";
                var resultado = con.Query<ColaboradorListagem>(query);
                return resultado.ToList();

            }


        }

        public List<ColaboradorListagem> ListarColaboradores(string nome, string param)
        {
            using (con)
            {
                var queryWhere = "";

                if(param == "id")
                {
                    queryWhere = $"idcolaborador = {nome}";
                }else
                {
                    queryWhere = $"Nome like '{nome}%'";
                }

                var query = $@"select idcolaborador, Nome, SobreNome, Sexo, Salario, PorcentagemDeComissao, DataDeNascimento, Cidade, UF, celular, email 
                               from Colaborador c Left outer join Endereco e on e.idEndereco = c.IdEndereco
                               Left outer join contato co on co.idContato = c.idContato where {queryWhere};";
                var resultado = con.Query<ColaboradorListagem>(query);
                return resultado.ToList();

            }
        }


        public void ExcluirTudo()
        {
            con.Open();

            var tran = con.BeginTransaction();
            try
            {
                Colaborador colaborador = new Colaborador();
                var query = $@"delete from colaborador";
                con.Execute(query, colaborador, tran);

                query = $@"delete from cliente";
                con.Execute(query, colaborador, tran);

                query = $@"delete from endereco ";
                con.Execute(query, colaborador.endereco, tran);

                query = $@"delete from contato";
                con.Execute(query, colaborador.contato, tran);

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                con.Close();
                throw new Exception();
            }
            con.Close();
        
    }
    }
}
