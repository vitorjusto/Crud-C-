using System.Data.SqlClient;
using CRUD_teste.Model;
using System.Collections.Generic;
using Dapper;
using System;
using crud_teste.Model;
using System.Linq;

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
                    colaborador.comissao = (double)reader["comissao"];


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
                    colaborador.Ativo = (bool)reader["Ativo"];

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
                    colaborador.endereco.Numero = (string)reader["numero"];
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
                        Salario = colaborador.Salario.GetAsDecimal(),
                        PorcentagemDeComissao = colaborador.PorcentagemDeComissao.ToDecimal(),
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
                    con.Execute(query, new
                    {
                        Salario = colaborador.Salario.GetAsDecimal(),
                        PorcentagemDeComissao = colaborador.PorcentagemDeComissao.ToDecimal(),
                        idColaborador = colaborador.idColaborador,
                    }, tran);
                    


                query = @"update DadosBancarios set Banco = @Banco, Agencia = @Agencia, Conta = @Conta, Digito = @Digito where  idDadosBancarios = @idDadosBancarios";
                con.Execute(query, colaborador.DadosBancarios, tran) ;



                    query = $@"update pessoa set nome = @nome, sobrenome = @SobreNome, sexo = @sexo, cpf = @cpf, DataDeNascimento = @DataDeNascimento, Ativo = @Ativo where idPessoa = @idPessoa";
                    con.Execute(query, new
                    {
                        nome = colaborador.Nome,
                        SobreNome = colaborador.SobreNome,
                        sexo = colaborador.Sexo,
                        cpf = colaborador.CPF.ToString(),
                        DataDeNascimento = colaborador.DataDeNascimento,
                        idPessoa = colaborador.IdPessoa,
                        Ativo = colaborador.Ativo,

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

        public void ExcluirColaborador(int id)
        {
            Colaborador cliente = new Colaborador();


            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                var query = @"select c.idColaborador, p.idpessoa, p.idContato, p.idendereco from colaborador c left outer join pessoa p on p.idPessoa = c.IdPessoa
                            where c.idColaborador = @idColaborador";

                var reader = con.ExecuteReader(query, new
                {
                    idCliente = id,
                }, tran);


                reader.Read();
                using (reader)
                {

                    cliente.IdPessoa = (int)reader["idpessoa"];
                    cliente.contato.idContato = (int)reader["idcontato"];
                    cliente.endereco.IdEndereco = (int)reader["idendereco"];
                }

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
        public List<ColaboradorListagem> ListarColaboradores()
        {

            using (con)
            {
                

                var query = @"select idcolaborador, p.idpessoa, Nome, SobreNome, Sexo, Salario, DataDeNascimento, Cidade, UF,bairro, logradouro, numero, celular,PorcentagemDeComissao, email, telefone, Ativo 
                               from Colaborador c Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato;";
                var resultado = con.Query<ColaboradorListagem>(query);
                return resultado.ToList();

            }


        }

        public List<ColaboradorListagem> ListarColaboradoresAtivos()
        {

            using (con)
            {


                var query = @"select idcolaborador, p.idpessoa, Nome, SobreNome, Sexo, Salario, DataDeNascimento, Cidade, UF,bairro, logradouro, numero, celular, email, telefone, Ativo 
                               from Colaborador c Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato where Ativo = 1;";
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

                var query = $@"select idcolaborador, p.idpessoa, Nome, SobreNome, Sexo, Salario,  DataDeNascimento, Cidade, UF ,bairro, logradouro, numero, celular, email, telefone, Ativo
                               from Colaborador c inner join pessoa p on p.IdPessoa = c.IdPessoa inner join Endereco e on e.idEndereco = p.IdEndereco
                               inner join contato co on co.idContato = p.idContato where {queryWhere};";
                var resultado = con.Query<ColaboradorListagem>(query);
                return resultado.ToList();

            }
        }

        public List<ColaboradorListagem> ListarColaboradoresAtivos(string nome, string param)
        {
            using (con)
            {
                var queryWhere = "";

                if (param == "id")
                {
                    queryWhere = $"idcolaborador = {nome}";
                }
                else
                {
                    queryWhere = $"Nome + ' ' + Sobrenome like '{nome}%'";
                }

                var query = $@"select idcolaborador, p.idpessoa, Nome, SobreNome, Sexo, Salario,  DataDeNascimento, Cidade, UF ,bairro, logradouro, numero, celular, email, telefone, Ativo
                               from Colaborador c inner join pessoa p on p.IdPessoa = c.IdPessoa inner join Endereco e on e.idEndereco = p.IdEndereco
                               inner join contato co on co.idContato = p.idContato where {queryWhere} and Ativo = 1;";
                var resultado = con.Query<ColaboradorListagem>(query);
                return resultado.ToList();

            }
        }

        public void AlterarAtivo(ColaboradorListagem colaborador)
        {
            try
            {
                var query = "";

                if (colaborador.Ativo)
                    query = @"update Pessoa set Ativo = 0 where IdPessoa = @IdPessoa";
                else
                    query = @"update Pessoa set Ativo = 1 where IdPessoa = @IdPessoa";
                con.Open();
                con.Execute(query, new
                {
                    IdPessoa = colaborador.idPessoa,
                });
                con.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
