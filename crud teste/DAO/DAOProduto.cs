using crud_teste.Model;
using crud_teste.Model.Listagem;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos.RelatorioDosProdutos;

namespace crud_teste.DAO
{
    public class DAOProduto
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public DAOProduto()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
        }



       


        public int Inserir(Produto produto)
        {
            using (con)
            {

                con.Open();
                try
                {


                    var query = @"Insert into produto(CodigoDeBarras, NomeProduto, PrecoDeVenda, PrecoDeCusto, Estoque, Ativo, Fabricante)
                                    OUTPUT INSERTED.idProduto
                                    Values(@CodigoDeBarras, @NomeDoProduto, @PrecoDeVenda, @PrecoDeCusto, @Estoque, @Ativo, @Fabricante)";

                    var IdProduto = int.Parse(con.ExecuteScalar(query, new
                    {
                        CodigoDeBarras = produto.CodigoDeBarras,
                        NomeDoProduto = produto.NomeDoProduto,
                        PrecoDeVenda = produto.PrecoDeVenda.GetAsDouble(),
                        PrecoDeCusto = produto.PrecoDeCusto.GetAsDouble(),
                        Estoque = produto.Estoque,
                        Ativo = produto.Ativo,
                        Fabricante = produto.Fabricante,


                    }).ToString()) ; ;

                    con.Close();
                    return IdProduto;
    
                }catch(Exception ex)
                {
                    con.Close();
                    throw new Exception(ex.Message);
                }
            }
        }


        public List<ProdutoListagem> Listar()
        {
            using (con)
            {
                var query = @"select idproduto, nomeProduto, precodevenda, fabricante, estoque, ativo from produto";
                var resultado = con.Query<ProdutoListagem>(query);
                return resultado.ToList();

            }
        }

        public List<ProdutoListagem> Listar(string pesquisa, string param)
        {
            using (con)
            {
                string queryWhere = "";
                if(param == "nome")
                {
                    queryWhere = $"nomeProduto like '{pesquisa}%'";
                }
                else
                {
                    queryWhere = $"IdProduto = {pesquisa}";
                }

                var query = $@"select idproduto, nomeProduto, precodevenda, fabricante, estoque, ativo from produto where {queryWhere}";
                var resultado = con.Query<ProdutoListagem>(query);
                return resultado.ToList();

            }
        }

        public List<ProdutoListagem> ListarAtivo(string pesquisa, string param)
        {
            {
                using (con)
                {
                    string queryWhere = "";
                    if (param == "nome")
                    {
                        queryWhere = $"nomeProduto like '{pesquisa}%'";
                    }
                    else
                    {
                        queryWhere = $"IdProduto = {pesquisa}";
                    }

                    var query = $@"select idproduto, nomeProduto, precodevenda, fabricante, estoque from produto where {queryWhere} and Ativo = 1 and Estoque > 0";
                    var resultado = con.Query<ProdutoListagem>(query);
                    return resultado.ToList();

                }
            }
        }


        public Produto Consultar(int id)
        {
            Produto produto = new Produto();
            produto.IdProduto = id;
            using (con)
            {
                con.Open();
                var query = @"select * from Produto where idproduto = @IdProduto";
                var reader = con.ExecuteReader(query, produto);
                reader.Read();
                using(reader)
                {
                    produto.NomeDoProduto = (string)reader["NomeProduto"];
                    produto.CodigoDeBarras = (string)reader["CodigoDeBarras"];
                    produto.PrecoDeCusto = (reader["PrecoDeCusto"].ToString());
                    produto.PrecoDeVenda = (reader["Precodevenda"].ToString());
                    produto.Estoque = (long)reader["Estoque"];
                    produto.Ativo = (bool)reader["Ativo"];
                    produto.Fabricante = (string)reader["fabricante"];

                }

                con.Close();
                return produto;
            }
        }

        public void Salvar(Produto produto)
        {
            using (con)
            {

                con.Open();
                try
                {


                    var query = @"update Produto set NomeProduto = @NomeDoProduto, CodigoDeBarras = @CodigoDeBarras, precodecusto = @PrecoDeCusto, precodevenda = @PrecodeVenda, Estoque = @Estoque, Fabricante= @Fabricante, Ativo = @Ativo where idProduto = @IdProduto";

                    con.Execute(query, new
                    {
                        CodigoDeBarras = produto.CodigoDeBarras,
                        NomeDoProduto = produto.NomeDoProduto,
                        PrecoDeVenda = produto.PrecoDeVenda.GetAsDouble(),
                        PrecoDeCusto = produto.PrecoDeCusto.GetAsDouble(),
                        Estoque = produto.Estoque,
                        Ativo = produto.Ativo,
                        Fabricante = produto.Fabricante,
                        IdProduto = produto.IdProduto,

                    });

                    con.Close();


                }
                catch (Exception ex)
                {
                    con.Close();
                    throw new Exception(ex.Message);
                }
            }
        }

        public List<ProdutoListagem> ListarAtivo()
        {
            using (con)
            {
                var query = @"select idproduto, nomeProduto, precodevenda, fabricante, estoque from produto where ativo = 1 and Estoque > 0";
                var resultado = con.Query<ProdutoListagem>(query);
                return resultado.ToList();

            }
        }

        public void Excluir(int id)
        {
            using (con)
            {

                con.Open();
                try
                {


                    var query = @"delete from Produto where idProduto = @IdProduto";

                    con.Execute(query, new { IdProduto = id, });

                    con.Close();


                }
                catch (Exception ex)
                {
                    con.Close();
                    throw new Exception(ex.Message);
                }
            }
        }

        public void aumentarEstoque(int id, int quantidade)
        {
            var query = "update produto set estoque += @quantidade where idProduto = @idProduto";
            try
            {
                con.Open();
                con.Execute(query, new {
                    quantidade = quantidade,
                    idProduto = id,
                });
                con.Close();

            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarAtivo(ProdutoListagem produto)
        {
            try
            {
                var query = "";

                if (produto.Ativo)
                    query = @"update Produto set Ativo = 0 where IdProduto = @IdProduto";
                else
                    query = @"update Produto set Ativo = 1 where IdProduto = @IdProduto";
                con.Open();
                con.Execute(query, new
                {
                    IdProduto = produto.IdProduto, 
                });
                con.Close();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void AlterarEstoque(int id, long estoque)
        {
            try
            {
                var query = "update Produto set Estoque = @Estoque where idProduto = @IdProduto";
                con.Open();
                con.Execute(query, new
                {
                    Estoque = estoque,
                    IdProduto = id,
                });
                con.Close();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<RelatorioProdutosVendaListagem> RelatorioDeVendaDosProdutos()
        {
            using (con)
            {
                var query = @"select p.idProduto, p.nomeProduto, p.Ativo,
                              Sum(Quantidade) as 'Quantidade', sum(precobruto) as 'TotalBruto', Sum(Desconto) as 'Desconto',
                              Sum(precoLiquido) - SUM(v.DescontoAVista / v.quantidadeunitario) as 'TotalLiquido',
                              Sum(c.TotalGasto) as 'TotalCusto', Sum(c.PrecoDeVenda) as 'TotalPrecoDeVenda', SUM(v.DescontoAVista / v.quantidadeunitario) as 'DescontoAVista' from Produto p 
                              inner join Carrinho c on c.idProduto = p.idProduto 
                              inner join Venda v on v.IdVenda = c.idVenda
                              where v.ativo = 1
                              GROUP BY p.IdProduto, p.NomeProduto, p.Ativo;
";
                var resultado = con.Query<RelatorioProdutosVendaListagem>(query);
                return resultado.ToList();

            }
        }

        public List<RelatorioProdutosVendaListagem> RelatorioDeVendaDosProdutos(pesquisar pesquisa)
        {
            using (con)
            {
                var query = @"select p.idProduto, p.nomeProduto, p.Ativo,
                              Sum(Quantidade) as 'Quantidade', sum(precobruto) as 'TotalBruto', Sum(Desconto) as 'Desconto',
                              Sum(precoLiquido) - SUM(v.DescontoAVista / v.quantidadeunitario) as 'TotalLiquido',
                              Sum(c.TotalGasto) as 'TotalCusto', Sum(c.PrecoDeVenda) as 'TotalPrecoDeVenda',
                              SUM(v.DescontoAVista / v.quantidadeunitario) as 'DescontoAVista'
                              from Produto p 
                              inner join Carrinho c on c.idProduto = p.idProduto 
							  inner join Venda v on v.IdVenda = c.idVenda
							  inner join cliente cl on cl.idCliente = v.idCliente
							  inner join pessoa pe on pe.idPessoa = cl.IdPessoa

							  where p.NomeProduto like @produto + '%' and pe.Nome + ' ' + pe.Sobrenome like @nome + '%' and v.Ativo = 1";

                if (pesquisa.pesquisarPorData)
                    query += @"and Cast(DiaDaVenda as date) between @DataInicial and @DataFinal ";

                query += @"GROUP BY p.IdProduto, p.NomeProduto, p.Ativo;";
                con.Open();
                    var resultado = con.Query<RelatorioProdutosVendaListagem>(query, new
                    {
                        nome = pesquisa.nomeDoCliente,
                        produto = pesquisa.nomeDoProduto,
                        DataInicial = pesquisa.DataInicial.ToString("dd/MM/yyyy"),
                        DataFinal = pesquisa.DataFinal.ToString("dd/MM/yyyy"),
                    });
                con.Close();
                    return resultado.ToList();


            }
        }

    }
}      