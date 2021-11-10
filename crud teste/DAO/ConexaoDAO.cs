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


                    var query = $@"Insert Into Endereco(Cep, Logradouro, Cidade, UF, Complemento, Bairro, numero) OUTPUT INSERTED.idendereco Values(@cep,@Logradouro,@Cidade,@UF, @Complemento, @Bairro, @Numero) ";
                    var idendereco = con.ExecuteScalar(query, new {
                        cep = cliente.endereco.Cep.ToString(),
                        logradouro = cliente.endereco.Logradouro,
                        cidade = cliente.endereco.Cidade,
                        UF = cliente.endereco.UF,
                        complemento = cliente.endereco.Complemento,
                        Bairro = cliente.endereco.Bairro,
                        numero = cliente.endereco.Numero,

                    }, tran);

                    query = @"Insert Into Contato(Email, telefone, ddi, celular) OUTPUT INSERTED.idContato  Values(@Email,@Telefone, @ddi, @Celular)";
                    var idcontato = con.ExecuteScalar(query, new
                    {
                        Email = cliente.contato.Email,
                        Telefone = cliente.contato.Telefone.ToString(),
                        DDI = cliente.contato.Celular.RetornarDDI(),
                        Celular = cliente.contato.Celular.RetornarCelular(),

                    }, tran) ;

                


                    cliente.endereco.IdEndereco = int.Parse(idendereco.ToString());
                    cliente.contato.idContato = int.Parse(idcontato.ToString());

                    query = $@"Insert Into Pessoa(Nome, sobrenome,  sexo, cpf, datadenascimento, idendereco,  idcontato) OUTPUT INSERTED.IdPessoa  Values(@Nome, @SobreNome, @Sexo, @CPF, @DataDeNascimento , {cliente.endereco.IdEndereco}, {cliente.contato.idContato})";
                    var idpessoa = con.ExecuteScalar(query, new
                    {


                        Nome = cliente.Nome,
                        sobrenome = cliente.SobreNome,
                        sexo = cliente.Sexo,
                        cpf = cliente.CPF.ToString(),
                        DataDeNascimento = cliente.DataDeNascimento,
                        idEndereco = cliente.endereco.IdEndereco,
                        idContato = cliente.contato.idContato,


                    }, tran) ;
                   


                    cliente.IdPessoa = int.Parse(idpessoa.ToString());
                    query = @"Insert  Into  cliente( valorlimite, idPessoa) OUTPUT INSERTED.idcliente Values(@LimiteDeCompra, @IdPessoa)";
                    cliente.idCliente = int.Parse(con.ExecuteScalar(query, cliente, tran).ToString());

                    tran.Commit();
                 }catch(Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception(ex.Message);

                }

                con.Close();
                return cliente.idCliente;
            }
        }
        
        public Cliente ConsultarCliente(int id)
        {

            Cliente  cliente = new Cliente();
            cliente.idCliente = id;
            using (con)
            {

                con.Open();
                var query = @"Select * from cliente where idCliente = @idCliente";
                var reader = con.ExecuteReader(query, cliente);
                reader.Read();
                using (reader)
                {
                    cliente.idCliente = (int)reader["idCliente"];
                    cliente.LimiteDeCompra = (decimal)reader["ValorLimite"];
                    cliente.IdPessoa = (int)reader["idPessoa"];


                }

                query = @"Select * from pessoa where IdPessoa = @IdPessoa";
                reader = con.ExecuteReader(query, cliente);
                reader.Read();

                using (reader)
                {
                    cliente.Nome = (string)reader["Nome"];
                    cliente.SobreNome = (string)reader["SobreNome"];
                    cliente.Sexo = (string)reader["Sexo"];
                    cliente.CPF = (string)reader["CPF"];
                    cliente.endereco.IdEndereco = (int)reader["idEndereco"];
                    cliente.DataDeNascimento = (DateTime)reader["DataDeNascimento"];
                    cliente.contato.idContato = (int)reader["idContato"];


                }

                query = @"select * from Endereco where idEndereco = @IdEndereco ";
                reader = con.ExecuteReader(query, cliente.endereco);
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

                query = @"select * from Contato where idcontato = @idContato ";
                reader = con.ExecuteReader(query, cliente.contato);
                reader.Read();

                using (reader)
                {
                    cliente.contato.Email = (string)reader["email"];
                    cliente.contato.Telefone = (string)reader["telefone"];
                    cliente.contato.Celular = (string)reader["celular"];
                    cliente.contato.Celular.DDI = (string)reader["DDI"];
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


                var query = @"update cliente set Valorlimite = @LimiteDeCompra  where idCliente = @idCliente";
                con.Execute(query, cliente, tran);

                 query = @"update pessoa set nome = @nome , sobrenome = @SobreNome, sexo = @sexo, cpf = @cpf,
                                DataDeNascimento = @DataDeNascimento where idPessoa = @idPessoa";
                 con.Execute(query, new { 
                 
                     nome = cliente.Nome,
                     sobrenome = cliente.SobreNome,
                     sexo = cliente.Sexo,
                     cpf = cliente.CPF.ToString(),
                     DataDeNascimento = cliente.DataDeNascimento,
                     idPessoa = cliente.IdPessoa,
                 
                 }, tran);


                    query = @"Update contato Set telefone = @Telefone, celular = @celular, ddi = @ddi, email = @email Where idcontato = @idContato";
                    con.Execute(query, new {
                        Telefone = cliente.contato.Telefone.ToString(),
                        celular = cliente.contato.Celular.RetornarCelular(),
                        DDI = cliente.contato.Celular.RetornarDDI(),
                        Email = cliente.contato.Email,
                        idContato = cliente.contato.idContato,

                    }, tran); ;


                 

                    query = $@"Update endereco Set cep = @cep, Logradouro = @Logradouro, cidade = @Cidade, UF = @UF, complemento = @Complemento, bairro = @Bairro, numero = @numero Where idendereco = @IdEndereco";
                con.Execute(query, new { 
                    cep = cliente.endereco.Cep.ToString(),
                    Logradouro = cliente.endereco.Logradouro,
                    cidade = cliente.endereco.Cidade,
                    UF = cliente.endereco.UF,
                    complemento = cliente.endereco.Complemento,
                    Bairro = cliente.endereco.Bairro,
                    numero = cliente.endereco.Numero,
                    IdEndereco = cliente.endereco.IdEndereco,
                
                }, tran);
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

            query = $@"delete from pessoa where idPessoa = @idPessoa";
            con.Execute(query, cliente, tran);

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

                var query = @"select idcliente, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone
                               from cliente c  Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato;";
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
                    
                    queryWhere = $"Nome like '{nome}%'";
                }
                var query = $@"select idcliente, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone
                               from cliente c  Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato where {queryWhere} ";
                var resultado = con.Query<ClienteListagem>(query);
                return resultado.ToList();

            }
        }

        public Colaborador ConsultarColaborador(int id)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.idColaborador = id; 
            using (con)
            {

                con.Open();
                var query = $"Select * from colaborador where idColaborador = @idcolaborador";
                var reader = con.ExecuteReader(query, colaborador);
                reader.Read();
                using (reader)
                {
                    colaborador.PorcentagemDeComissao = (decimal)reader["PorcentagemDeComissao"];

                    colaborador.Salario = (decimal)reader["Salario"];
                    colaborador.IdPessoa = (int)reader["idPessoa"];
                    colaborador.DadosBancarios.IdDadosBancarios = (int)reader["idDadosBancarios"];


                }

                query = $"Select * from DadosBancarios where idDadosBancarios = @idDadosBancarios";
                reader = con.ExecuteReader(query, colaborador.DadosBancarios);
                reader.Read();
                using (reader)
                {
                    colaborador.DadosBancarios.Banco = (string)reader["Banco"];
                    colaborador.DadosBancarios.Agencia = (int)reader["Agencia"];
                    colaborador.DadosBancarios.Conta = (int)reader["Conta"];
                    colaborador.DadosBancarios.Digito = (int)reader["Digito"];
                }

                query = $"Select * from pessoa where idPessoa = @IdPessoa";
                 reader = con.ExecuteReader(query, colaborador);
                reader.Read();
                using (reader)
                {
                    colaborador.Nome = (string)reader["Nome"];
                    colaborador.SobreNome = (string)reader["SobreNome"];
                    colaborador.Sexo = (string)reader["Sexo"];
                    colaborador.CPF = (string)reader["CPF"];
                    colaborador.endereco.IdEndereco = (int)reader["idEndereco"];
                    colaborador.DataDeNascimento = (DateTime)reader["DataDeNascimento"];
                    colaborador.contato.idContato = (int)reader["idContato"];


                }


                query = $"select * from Endereco where idEndereco = @IdEndereco ";
                reader = con.ExecuteReader(query, colaborador.endereco);
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

                query = $"select * from Contato where idcontato = @idContato ";
                reader = con.ExecuteReader(query, colaborador.contato);
                reader.Read();

                using (reader)
                {
                    colaborador.contato.Email = (string)reader["email"];
                    colaborador.contato.Telefone = (string)reader["telefone"];
                    colaborador.contato.Celular = (string)reader["celular"];
                    colaborador.contato.Celular.DDI = (string)reader["DDI"];
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
                    var query = $@"Insert Into Endereco(Cep, Logradouro, Cidade, UF, Complemento, Bairro, numero) OUTPUT INSERTED.idendereco Values(@cep,@Logradouro,@Cidade,@UF, @Complemento, @Bairro, @Numero) ";
                    var idendereco = con.ExecuteScalar(query, new
                    {
                        cep = colaborador.endereco.Cep.ToString(),
                        Logradouro = colaborador.endereco.Logradouro,
                        cidade = colaborador.endereco.Cidade,
                        UF = colaborador.endereco.UF,
                        complemento = colaborador.endereco.Complemento,
                        Bairro = colaborador.endereco.Bairro,
                        numero = colaborador.endereco.Numero,
                        IdEndereco = colaborador.endereco.IdEndereco,
                    }, tran);

                    query = @"Insert Into Contato(Email, telefone, ddi, celular) OUTPUT INSERTED.idContato  Values(@Email,@Telefone, @DDI, @Celular)";
                    var idcontato = con.ExecuteScalar(query, new
                    {
                        Email = colaborador.contato.Email,
                        Telefone = colaborador.contato.Telefone.ToString(),
                        DDI = colaborador.contato.Celular.RetornarDDI(),
                        Celular = colaborador.contato.Celular.RetornarCelular(),

                    }, tran) ;

                    query = @"Insert Into DadosBancarios(Banco, Agencia, conta, digito) OUTPUT INSERTED.idDadosBancarios  Values(@Banco,@Agencia, @Conta, @Digito)";
                    var idBanco = con.ExecuteScalar(query, colaborador.DadosBancarios, tran);


                    colaborador.endereco.IdEndereco = int.Parse(idendereco.ToString());
                    colaborador.contato.idContato = int.Parse(idcontato.ToString());

                    query = $@"Insert Into Pessoa(Nome, sobrenome,  sexo, cpf, datadenascimento, idendereco,  idcontato) OUTPUT INSERTED.idPessoa  Values(@Nome, @SobreNome, @Sexo, @cpf, @DataDeNascimento , @idEndereco, @idContato)";
                    var idpessoa = con.ExecuteScalar(query, new { 
                    nome = colaborador.Nome,
                    sobrenome = colaborador.SobreNome,
                    sexo = colaborador.Sexo,
                    cpf = colaborador.CPF.ToString(),
                    datadeNascimento = colaborador.DataDeNascimento,
                    idEndereco = colaborador.endereco.IdEndereco,
                    idContato = colaborador.contato.idContato
                    
                    }, tran);

                    colaborador.IdPessoa = int.Parse(idpessoa.ToString());
                    var cpf = colaborador.CPF.ToString();
                    query = $@"Insert  Into Colaborador(Salario, PorcentagemDeComissao, idPessoa, idDadosBancarios) OUTPUT INSERTED.idcolaborador Values( @Salario, @PorcentagemDeComissao, @idPessoa, @idDadosBancarios)";
                    colaborador.idColaborador = int.Parse(con.ExecuteScalar(query, new
                    {
                        Salario = colaborador.Salario,
                        PorcentagemDeComissao = colaborador.PorcentagemDeComissao,
                        idpessoa = idpessoa,
                        idDadosBancarios = idBanco,

                    }, tran).ToString()) ;;

                tran.Commit();
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception(ex.Message);

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

                var query = $@"update colaborador set   salario = @Salario, porcentagemDecomissao = @PorcentagemDeComissao  where idColaborador = @idColaborador";
                con.Execute(query, colaborador, tran);


                query = @"update DadosBancarios set Banco = @Banco, Agencia = @Agencia, Conta = @Conta, Digito = @Digito where  idDadosBancarios = @idDadosBancarios";
                con.Execute(query, colaborador.DadosBancarios, tran) ;



                    query = $@"update pessoa set nome = @nome, sobrenome = @SobreNome, sexo = @sexo, cpf = @cpf, DataDeNascimento = @DataDeNascimento where idPessoa = @idPessoa";
                    con.Execute(query, new
                    {
                        nome = colaborador.Nome,
                        SobreNome = colaborador.SobreNome,
                        sexo = colaborador.Sexo,
                        cpf = colaborador.CPF.ToString(),
                        DataDeNascimento = colaborador.DataDeNascimento,
                        idPessoa = colaborador.IdPessoa,

                    }, tran) ;


                    query = @"update contato set telefone = @Telefone, celular = @celular, ddi = @ddi, email = @email where idcontato = @idContato";
                    con.Execute(query, new
                    {
                        telefone = colaborador.contato.Telefone.ToString(),
                        celular = colaborador.contato.Celular.RetornarCelular(),
                        DDI = colaborador.contato.Celular.RetornarDDI(),
                        Email =colaborador.contato.Email,
                        idContato = colaborador.contato.idContato,

                    }, tran) ;

                   

                    query = $@"update endereco set cep = @cep, Logradouro = @Logradouro, cidade = @Cidade, UF = @UF, complemento = @Complemento, bairro = @Bairro, numero = @numero where idendereco = @IdEndereco";
                con.Execute(query, new {
                cep = colaborador.endereco.Cep.ToString(),
                logradouro = colaborador.endereco.Logradouro,
                cidade = colaborador.endereco.Cidade,
                UF = colaborador.endereco.UF,
                complemento = colaborador.endereco.Complemento,
                Bairro = colaborador.endereco.Bairro,
                Numero = colaborador.endereco.Numero,
                IdEndereco = colaborador.endereco.IdEndereco,
                
                }, tran);
                tran.Commit();
                }
                catch (Exception ex)
                {
                tran.Rollback();
                con.Close();
                throw new Exception(ex.Message);
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

            query = $@"delete from dadosBancarios where idDadosBancarios = @idDadosBancarios";
            con.Execute(query, colaborador.DadosBancarios, tran);
                
            query = $@"delete from pessoa where idpessoa = @idPessoa";
            con.Execute(query, colaborador, tran);

             query = $@"delete from endereco where idendereco = @IdEndereco";
            con.Execute(query, colaborador.endereco, tran);

            query = $@"delete from contato where idcontato = @idContato";
            con.Execute(query, colaborador.contato, tran);

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

        public List<ColaboradorListagem> ListarColaboradores()
        {

            using (con)
            {

                var query = @"select idcolaborador, Nome, SobreNome, Sexo, Salario, DataDeNascimento, Cidade, UF,bairro, logradouro, numero, celular, email, telefone 
                               from Colaborador c Right outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato;";
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

                var query = $@"select idcolaborador, Nome, SobreNome, Sexo, Salario,  DataDeNascimento, Cidade, UF ,bairro, logradouro, numero, celular, email, telefone 
                               from Colaborador c Right outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato where {queryWhere};";
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


                query = $@"delete from dadosBancarios";
                con.Execute(query, colaborador, tran);
                query = $@"delete from cliente";
                con.Execute(query, colaborador, tran);

                query = $@"delete from pessoa";
                con.Execute(query, colaborador, tran);

                query = $@"delete from endereco ";
                con.Execute(query, colaborador.endereco, tran);

                query = $@"delete from contato";
                con.Execute(query, colaborador.contato, tran);


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
}
