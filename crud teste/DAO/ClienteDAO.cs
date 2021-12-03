using crud_teste.Model;
using crud_teste.Model.Listagem;
using CRUD_teste.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos.RelatorioDoClientes;

namespace crud_teste.DAO
{
    class ClienteDAO
    {
        SqlConnection con = new SqlConnection();


        public ClienteDAO()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
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
                    var idendereco = con.ExecuteScalar(query, new
                    {
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

                    }, tran);




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


                    }, tran);



                    cliente.IdPessoa = int.Parse(idpessoa.ToString());
                    query = @"Insert  Into  cliente( valorlimite, idPessoa, LimiteRestante) OUTPUT INSERTED.idcliente Values(@LimiteDeCompra, @IdPessoa, @LimiteRestante)";
                    cliente.idCliente = int.Parse(con.ExecuteScalar(query, new
                    {
                        LimiteDeCompra = cliente.LimiteDeCompra.GetAsDouble(),
                        cliente.IdPessoa,
                        LimiteRestante = cliente.LimiteDeCompra.GetAsDecimal(),
                    }, tran).ToString()) ;

                    tran.Commit();
                }
                catch (Exception ex)
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

            Cliente cliente = new Cliente();
            cliente.idCliente = id;

            con.Open();
            var query = @"Select * from cliente where idCliente = @idCliente";
            var reader = con.ExecuteReader(query, cliente);
            reader.Read();
            using (reader)
            {
                cliente.idCliente = (int)reader["idCliente"];
                cliente.LimiteDeCompra = (decimal)reader["ValorLimite"];
                cliente.LimiteRestante = (decimal)reader["LimiteRestante"];
                cliente.IdPessoa = (int)reader["idPessoa"];
            }

            cliente.LimiteAcumulado = cliente.LimiteDeCompra.GetAsDecimal() - cliente.LimiteRestante.GetAsDecimal();

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
                cliente.Ativo = (bool)reader["Ativo"];

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


                    var query = @"update cliente set Valorlimite = @LimiteDeCompra, LimiteRestante = @LimiteRestante  where idCliente = @idCliente";
                    con.Execute(query, new
                    {
                        LimiteDeCompra = cliente.LimiteDeCompra.GetAsDouble(),
                        LimiteRestante = cliente.LimiteRestante.GetAsDouble(),
                        idCliente = cliente.idCliente,
                    }, tran);

                    query = @"update pessoa set nome = @nome , sobrenome = @SobreNome, sexo = @sexo, cpf = @cpf,
                                DataDeNascimento = @DataDeNascimento, Ativo = @Ativo where idPessoa = @idPessoa";
                    con.Execute(query, new
                    {

                        nome = cliente.Nome,
                        sobrenome = cliente.SobreNome,
                        sexo = cliente.Sexo,
                        cpf = cliente.CPF.ToString(),
                        DataDeNascimento = cliente.DataDeNascimento,
                        idPessoa = cliente.IdPessoa,
                        Ativo = cliente.Ativo,

                    }, tran);


                    query = @"Update contato Set telefone = @Telefone, celular = @celular, ddi = @ddi, email = @email Where idcontato = @idContato";
                    con.Execute(query, new
                    {
                        Telefone = cliente.contato.Telefone.ToString(),
                        celular = cliente.contato.Celular.RetornarCelular(),
                        DDI = cliente.contato.Celular.RetornarDDI(),
                        Email = cliente.contato.Email,
                        idContato = cliente.contato.idContato,

                    }, tran); ;




                    query = $@"Update endereco Set cep = @cep, Logradouro = @Logradouro, cidade = @Cidade, UF = @UF, complemento = @Complemento, bairro = @Bairro, numero = @numero Where idendereco = @IdEndereco";
                    con.Execute(query, new
                    {
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
                catch (Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception(ex.Message);

                }
                con.Close();

            }
        }

        public void AlterarAtivo(ClienteListagem cliente)
        {
            try
            {
                var query = "";

                if (cliente.Ativo)
                    query = @"update Pessoa set Ativo = 0 where IdPessoa = @IdPessoa";
                else
                    query = @"update Pessoa set Ativo = 1 where IdPessoa = @IdPessoa";
                con.Open();
                con.Execute(query, new
                {
                    IdPessoa = cliente.idPessoa,
                });
                con.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void ExcluirCliente(Cliente cliente)
        {
            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                var query = $@"delete from cliente where idcliente = @idCliente";
                con.Execute(query, cliente, tran);

                query = $@"delete from pessoa where idPessoa = @idPessoa";
                con.Execute(query, cliente, tran);

                query = $@"delete from endereco where idendereco = @IdEndereco";
                con.Execute(query, cliente.endereco, tran);

                query = $@"delete from contato where idcontato = @idContato";
                con.Execute(query, cliente.contato, tran);



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

        public void ExcluirCliente(int id)
        {
            Cliente cliente = new Cliente();


            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                var query = @"select c.idCliente, p.idpessoa, p.idContato, p.idendereco from cliente c left outer join pessoa p on p.idPessoa = c.IdPessoa
                            where c.idCliente = @idCliente";

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


        public List<ClienteListagem> ListarCliente()
        {
            using (con)
            {
                try
                {


                    var query = @"select idcliente, p.idPessoa, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone, Ativo
                               from cliente c  Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato;";
                    var resultado = con.Query<ClienteListagem>(query);
                    return resultado.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        public List<ClienteListagem> ListarClienteAtivos()
        {
            using (con)
            {
                try
                {


                    var query = @"select idcliente, p.idPessoa, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone, Ativo
                               from cliente c  inner join pessoa p on p.IdPessoa = c.IdPessoa inner join Endereco e on e.idEndereco = p.IdEndereco
                               inner join contato co on co.idContato = p.idContato where Ativo = 1;";
                    var resultado = con.Query<ClienteListagem>(query);
                    return resultado.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }

            }
        }

        public List<ClienteListagem> ListarCliente(string nome, string param)
        {
            using (con)
            {
                var queryWhere = "";
                if (param == "id")
                {
                    queryWhere = $"idcliente = {nome}";
                }
                else
                {

                    queryWhere = $"Nome like '{nome}%'";
                }
                var query = $@"select idcliente, p.idPessoa, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone, Ativo
                               from cliente c  Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato where {queryWhere} ";
                var resultado = con.Query<ClienteListagem>(query);
                return resultado.ToList();

            }
        }

        public List<ClienteListagem> ListarClienteAtivos(string nome, string param)
        {
            using (con)
            {
                var queryWhere = "";
                if (param == "id")
                {
                    queryWhere = $"idcliente = {nome}";
                }
                else
                {

                    queryWhere = $"Nome like '{nome}%'";
                }
                var query = $@"select idcliente, p.idPessoa, Nome, Sobrenome, Sexo, ValorLimite, DataDeNascimento, Cidade, UF, celular,logradouro, bairro, numero, email, telefone, Ativo
                               from cliente c  Left outer join pessoa p on p.IdPessoa = c.IdPessoa Left outer join Endereco e on e.idEndereco = p.IdEndereco
                               Left outer join contato co on co.idContato = p.idContato where {queryWhere} and Ativo = 1 ";
                var resultado = con.Query<ClienteListagem>(query);
                return resultado.ToList();

            }

        }

        public List<RelatorioClienteListagem> RelatorioDeVenda()
        {
            using (con)
            {
                var query = @"select c.idcliente, nome, sobrenome, COUNT(V.idvenda) as 'QuantidadeDeVenda',
                            SUM(V.quantidadetotal) as 'QuantidadeTotal',
                            SUM(V.TotalBruto) as 'TotalBruto', SUM(v.TotalDeDesconto) as 'TotalDeDesconto',
                            sum(v.DescontoAVista) as 'TotalDedescontoAVista', SUM(v.TotalLiquido) as 'TotalLiquido',
                            c.LimiteRestante, p.Ativo, SUM(ca.PrecoDeCusto) * SUM(ca.Quantidade) as 'PrecoDeCusto'

                            from cliente c
                            inner join pessoa p on p.idPessoa = c.IdPessoa
                            inner join Venda v on v.idCliente = c.idCliente
							inner join Carrinho ca on v.idVenda = ca.idVenda

                            where p.ativo = 1

                            group by c.idCliente, Nome, Sobrenome, LimiteRestante, p.ativo ";
                
                var resultado = con.Query<RelatorioClienteListagem>(query);
                return resultado.ToList();
            }
        }


        public List<RelatorioClienteListagem> RelatorioDeVenda(Pesquisa pesquisa)
        {


            var query = $@"select ";

            if (pesquisa.considerarTopResults)
                query += $@"Top (@TopResultado) ";

            query += $@"c.idcliente, nome, sobrenome, COUNT(V.idvenda) as 'QuantidadeDeVenda',
                            SUM(V.quantidadetotal) as 'QuantidadeTotal',
                            SUM(V.TotalBruto) as 'TotalBruto', SUM(v.TotalDeDesconto) as 'TotalDeDesconto',
                            sum(v.DescontoAVista) as 'TotalDedescontoAVista', SUM(v.TotalLiquido) as 'TotalLiquido',
                            c.LimiteRestante, p.Ativo,  SUM(ca.PrecoDeVenda), sum(ca.PrecoDeCusto),
                            SUM(ca.PrecoDeCusto) * SUM(ca.Quantidade) as 'PrecoDeCusto'

                            from cliente c
                            inner join pessoa p on p.idPessoa = c.IdPessoa
                            inner join Venda v on v.idCliente = c.idCliente
                            inner join Carrinho ca on v.idVenda = ca.idVenda

                            where nome like @Nome +'%' and Cast(DiaDaVenda as date) between @DataInicial and @DataFinal ";


            if (pesquisa.comAtivo)
                query += "and p.Ativo = 1";

             query += "group by c.idCliente, Nome, Sobrenome, LimiteRestante, p.ativo ";

            if (!string.IsNullOrEmpty(pesquisa.condicao))
            {
                if (pesquisa.condicao.Equals("entre"))
                {
                    query += $@"Having sum(TotalLiquido) between @ValorInicial and @ValorFinal ";
                }
                else
                {
                    query += $@"Having sum(TotalLiquido) {pesquisa.condicao} @ValorInicial ";
                }
            }

            query += $@"order by {pesquisa.OrdernarPor} {pesquisa.crescente}";

            using (con)
            {
                
                var resultado = con.Query<RelatorioClienteListagem>(query, new
                {
                    pesquisa.Nome,
                    DataInicial = pesquisa.DataInicial.ToString("dd/MM/yyyy"),
                    DataFinal = pesquisa.DataFinal.ToString("dd/MM/yyyy"),
                    ValorInicial = pesquisa.valorLiquidoInicial.GetAsDecimal(),
                    ValorFinal = pesquisa.ValorLiquidoFinal.GetAsDecimal(),
                    TopResultado = pesquisa.topresultadosnumero,
                }); ;

                var oi = resultado.ToList();
                return resultado.ToList();
            }
        }
    }
}
