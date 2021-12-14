using crud_teste.Model;
using crud_teste.Model.Listagem;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static crud_teste.vieew.ListaDePedidos.ListagemDePedidos;

namespace crud_teste.DAO
{
    class VendaDAO
    {
        SqlConnection con = new SqlConnection();

        public VendaDAO()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
        }

        

        public void cadastrar(Venda venda)
        {


            var query = @"Insert Into Venda(TotalBruto, TotalDeDesconto, TotalLiquido, MesesAPrazo, quantidadetotal, quantidadeunitario, tipodevenda, idCliente, idColaborador, DescontoAVista, DiaDaVenda, TotalGasto) OUTPUT INSERTED.idVenda 
                          Values(@TotalBruto, @TotalDeDesconto, @TotalLiquido, @mesesaprazo, @quantidadedetotal, @quantidadeunitario, @tipodevenda, @idCliente, @IdColaborador, @DescontoAVista, @DiaDaVenda, @TotalGasto)";
            var querycarrinho = @"Insert Into Carrinho(Quantidade, Desconto, precoBruto, precoliquido, idVenda, idproduto, precodecusto, precodevenda, totalgasto)  Values(@Quantidade, @Desconto, @precoBruto, @precoliquido, @idVenda, @idProduto,  @precodecusto, @precodevenda, @totalgasto)";
            var queryproduto = @"update Produto set Estoque -= @Quantidade where idProduto = @IdProduto";
            var DarCommissao = @"update Colaborador set comissao = @comissao where idColaborador = @idColaborador";
            var AlterarLimite = @"update Cliente set LimiteRestante -= @ValorTotal where idCliente = @idCliente";

            con.Open();
            var tran = con.BeginTransaction();
            try
            {

                var idVenda = int.Parse(con.ExecuteScalar(query, new
                {
                    TotalBruto = venda.TotalBruto.GetAsDouble(),
                    TotalDeDesconto = venda.TotalDeDesconto.GetAsDouble(),
                    TotalLiquido = venda.TotalLiquido.GetAsDouble(),
                    mesesaprazo = venda.MesesAPrazo,
                    quantidadedetotal = venda.QuantidadeDeTotal,
                    quantidadeunitario = venda.QuantidadeUnitario,
                    tipodevenda = venda.TipoDeVenda,
                    venda.cliente.idCliente,
                    IdColaborador = venda.colaborador.idColaborador,
                    DescontoAVista = venda.DescontoAVista.GetAsDouble(),
                    venda.DiaDaVenda,
                    TotalGasto = venda.Pedido_Produto.Sum(x => x.precoDeCusto.GetAsDecimal() * x.quantidade)
                }
                , tran).ToString()) ;
                
                foreach (var carrinho in venda.Pedido_Produto)
                {
                    carrinho.idVenda = idVenda;
                    con.Execute(querycarrinho, new
                    {
                        Quantidade = carrinho.quantidade,
                        Desconto = carrinho.Desconto.GetAsDouble(),
                        precoBruto = carrinho.PrecoBruto.GetAsDouble(),
                        precoLiquido = carrinho.PrecoLiquido.GetAsDouble(),
                        carrinho.idVenda,
                        idProduto = carrinho.produto.IdProduto,
                        precodecusto = carrinho.precoDeCusto.GetAsDouble(),
                        precodevenda = carrinho.precoDeVenda.GetAsDouble(),
                        totalGasto = carrinho.precoDeCusto.GetAsDouble() * carrinho.quantidade,
                    }, tran) ;
                    con.Execute(queryproduto, new
                    {
                        Quantidade = carrinho.quantidade,
                        carrinho.produto.IdProduto,

                    }, tran);

                }

                con.Execute(DarCommissao, new
                {
                    comissao = venda.colaborador.PorcentagemDeComissao.ToDecimal() * venda.QuantidadeDeTotal,
                    venda.colaborador.idColaborador,
                }, tran);

                if (venda.TipoDeVenda.Equals("A Prazo"))
                    con.Execute(AlterarLimite, new
                    {
                        ValorTotal = venda.TotalLiquido.GetAsDecimal(),
                        venda.cliente.idCliente,
                    }, tran);

                tran.Commit();
                con.Close();
            }catch(Exception ex)
            {
                tran.Rollback();
                con.Close();
                throw new Exception(ex.Message);
            }
        }

        internal void SalvarVenda(Venda venda)
        {
            var query = "update venda set TotalBruto = @TotalBruto, TotalDeDesconto = @TotalDeDesconto, TotalLiquido = @TotalLiquido, " +
                "mesesaprazo = @MesesAPrazo, quantidadetotal = @quantidadetotal, quantidadeunitario = @quantidadeunitario, TipoDeVenda = @TipoDeVenda, " +
                "idCliente = @idCliente, idColaborador = @idColaborador, DescontoAVista = @DescontoAVista where idVenda = @idVenda";

            var queryPedido_Produto = "update Carrinho set Quantidade = @quantidade, Desconto = @desconto, precoBruto = @precoBruto, precoLiquido = @precoLiquido, " +
                "PrecoDeCusto = @precoDeCusto, PrecoDeVenda = @PrecoDeVenda, totalgasto = @totalgasto  where idCarrinho = @idCarrinho";

            var querycarrinho = @"Insert Into Carrinho(Quantidade, Desconto, precoBruto, precoliquido, idVenda, idproduto, precodecusto, precodevenda, totalgasto)  
                                Values(@Quantidade, @Desconto, @precoBruto, @precoliquido, @idVenda, @idProduto,  @precodecusto, @precodevenda, @totalgasto)";

            var updateEstoque = @"update Produto set Estoque = @estoque where idProduto = @idProduto";

          
            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                
                
                con.Execute(query, new
                {
                    TotalBruto = venda.TotalBruto.GetAsDouble(),
                    TotalDeDesconto = venda.TotalDeDesconto.GetAsDouble(),
                    TotalLiquido = venda.TotalLiquido.GetAsDouble(),
                    MesesAPrazo = venda.MesesAPrazo,
                    quantidadetotal = venda.QuantidadeDeTotal,
                    quantidadeunitario = venda.QuantidadeUnitario,
                    TipoDeVenda = venda.TipoDeVenda,
                    idCliente = venda.cliente.idCliente,
                    idColaborador = venda.colaborador.idColaborador,
                    DescontoAVista = venda.DescontoAVista.GetAsDouble(),
                    idVenda = venda.IdVenda,
                }, tran) ;

                foreach(var pedido in venda.Pedido_Produto)
                {
                    if (pedido.IdCarrinho == 0)
                    {
                        con.Execute(querycarrinho, new
                        {
                            quantidade = pedido.quantidade,
                            desconto = pedido.Desconto.GetAsDouble(),
                            precoBruto = pedido.PrecoBruto.GetAsDouble(),
                            precoLiquido = pedido.PrecoLiquido.GetAsDouble(),
                            precoDeCusto = pedido.precoDeCusto.GetAsDouble(),
                            precoDeVenda = pedido.precoDeVenda.GetAsDouble(),
                            idVenda = venda.IdVenda,
                            idProduto = pedido.produto.IdProduto,
                            totalGasto = pedido.precoDeCusto.GetAsDouble() * pedido.quantidade,
                        }, tran);
                    }
                    else
                    {
                        con.Execute(queryPedido_Produto, new
                        {
                            quantidade = pedido.quantidade,
                            desconto = pedido.Desconto.GetAsDouble(),
                            precoBruto = pedido.PrecoBruto.GetAsDouble(),
                            precoLiquido = pedido.PrecoLiquido.GetAsDouble(),
                            precoDeCusto = pedido.precoDeCusto.GetAsDouble(),
                            precoDeVenda = pedido.precoDeVenda.GetAsDouble(),
                            idCarrinho = pedido.IdCarrinho,
                            totalGasto = pedido.precoDeCusto.GetAsDouble() * pedido.quantidade,
                        }, tran);
                    }

                    con.Execute(updateEstoque, new
                    {
                        estoque = pedido.quantidadeRestante,
                        idProduto = pedido.produto.IdProduto,
                    }, tran);

                    

                }
                
                tran.Commit();
                con.Close();
               
            }catch(Exception ex)
            {
                
                tran.Rollback();
                con.Close();
                throw new Exception(ex.Message);
            }


        }

        internal void ExcluirVenda(int id)
        {
            try
            {
                var query = @"delete from venda where idVenda = @idVenda";
                con.Open();
                con.Execute(query, new {
                    idVenda = id,
                });
                con.Close();

            }catch(Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message); 
            }
        }

        public List<PedidoListagem> ListarPedidos()
        {
            List<PedidoListagem> resultados = new List<PedidoListagem>();

            try
            {

                var query = @"select idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda,
                            v.idCliente, v.idColaborador, v.DiaDaVenda, DescontoAVista, P.Nome as 'NomeCliente', P.Sobrenome as 'sobrenomeCliente',
                            P2.Nome as 'nomeColaborador', P2.Sobrenome as 'sobrenomeColaborador', v.ativo
                            from Venda v
                            inner join cliente Cl on Cl.idCliente = v.idCliente inner join pessoa P on Cl.IdPessoa = P.idPessoa
                            inner join Colaborador Co on Co.idColaborador = v.idColaborador inner join pessoa P2 on Co.IdPessoa = P2.idPessoa";

                con.Open();
                resultados = con.Query<PedidoListagem>(query).ToList();
                con.Close();

                query = "select * from Carrinho where idVenda = @idVenda";
                var index = 0;
                con.Open();
                foreach (var resultado in resultados)
                {

                    resultados[index].carrinhos = con.Query<Pedido_Produto>(query, new
                    {
                        idVenda = resultado.IdVenda,
                    }).ToList() ;

                    index++;
                }
                con.Close();
                return resultados;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message);
            }

        }

        public List<PedidoListagem> ListarPedidos(pesquisar pesquisa)
        {
            List<PedidoListagem> resultados = new List<PedidoListagem>();
            try
            {

                var query = @"
                            select v.idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda,
                            v.idCliente, v.idColaborador, v.DiaDaVenda, DescontoAVista, P.Nome as 'NomeCliente', P.Sobrenome as 'sobrenomeCliente',
                            P2.Nome as 'nomeColaborador', P2.Sobrenome as 'sobrenomeColaborador', v.ativo

                            from Venda v 
                            inner join cliente Cl on Cl.idCliente = v.idCliente inner join pessoa P on Cl.IdPessoa = P.idPessoa
                            inner join Colaborador Co on Co.idColaborador = v.idColaborador inner join pessoa P2 on Co.IdPessoa = P2.idPessoa
							inner join Carrinho ca on ca.idVenda = v.IdVenda inner join Produto pr on pr.IdProduto = ca.idProduto

							where  P.nome like @NomeCliente + '%' and P2.nome like @NomeColaborador + '%' and pr.NomeProduto like @NomeProduto + '%' ";

                if(pesquisa.PesquisarPorData)
                {
                    query += @"and Cast(DiaDaVenda as date) between @DataInicial and @DataFinal";
                }

                query += @" group By v.idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda," +
                         @"   v.idCliente, v.idColaborador, v.DiaDaVenda, DescontoAVista, P.Nome, P.Sobrenome," +
                         @"  P2.Nome, P2.Sobrenome, v.ativo";


                con.Open();
                resultados = con.Query<PedidoListagem>(query, new
                {
                    NomeCliente = pesquisa.nomeCliente,
                    NomeColaborador = pesquisa.nomeColaborador,
                    NomeProduto = pesquisa.nomeProduto,
                    DataInicial = pesquisa.dataInicial.ToString("dd/MM/yyyy"),
                    DataFinal = pesquisa.dataFinal.ToString("dd/MM/yyyy"),
                }).ToList();
                con.Close();

                return resultados;
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message);
            }

        }


        public Venda ConsultarVenda(int id)
        {
            Venda venda = new Venda();
            venda.IdVenda = id;
            using (con)
            {
               
                var query = @"select * from venda where idvenda = @IdVenda";
                con.Open();
                var reader = con.ExecuteReader(query, venda);
                
                reader.Read();
                using (reader)
                {
                    venda.MesesAPrazo = (int)reader["mesesaprazo"];
                    venda.cliente.idCliente = (int)reader["idCliente"];
                    venda.colaborador.idColaborador = (int)reader["idColaborador"];
                    venda.DescontoAVista = (double)reader["DescontoAVista"];
                    venda.TipoDeVenda = (string)reader["TipoDeVenda"];
                    venda.Ativo = (bool)reader["ativo"];
                }


                query = "select c.IdCarrinho, c.Quantidade, c.Desconto, c.precobruto, c.precoliquido, c.idVenda, c.idProduto, c.PrecoDeCusto as 'carrinhoPrecoDeCusto'," +
                    " c.PrecoDeVenda as 'carrinhoPrecoDeVenda', p.CodigoDeBarras, p.NomeProduto, p.PrecoDeVenda as 'produtoPrecoDeVenda', p.PrecoDeCusto as 'produtoPrecoDeCusto'," +
                    " p.Estoque, p.Ativo, p.Fabricante from Carrinho" +
                    " c left outer join Produto p on p.IdProduto = c.idProduto where idVenda = @IdVenda";
                var resultados = con.Query<dynamic>(query, new
                {
                    IdVenda = id,
                });
                con.Close();

                
                foreach (var resultado in resultados)
                {
                    Pedido_Produto lista = new Pedido_Produto();

                    lista.IdCarrinho = (int)resultado.IdCarrinho;
                    lista.quantidade = (long)resultado.Quantidade;
                    lista.Desconto = (double)resultado.Desconto;
                    lista.PrecoBruto = (double)resultado.precobruto;
                    lista.PrecoLiquido = (double)resultado.precoliquido;
                    lista.produto.IdProduto = (int)resultado.idProduto;
                    lista.precoDeCusto = (double)resultado.carrinhoPrecoDeCusto;
                    lista.precoDeVenda = (double)resultado.carrinhoPrecoDeVenda;
                    lista.idVenda = id;

                    lista.produto.CodigoDeBarras = (string)resultado.CodigoDeBarras;
                    lista.produto.NomeDoProduto = (string)resultado.NomeProduto;
                    lista.produto.PrecoDeVenda = (double)resultado.produtoPrecoDeVenda;
                    lista.produto.PrecoDeCusto = (double)resultado.produtoPrecoDeCusto;
                    lista.produto.Estoque = (long)resultado.Estoque;
                    lista.produto.Ativo = (bool)resultado.Ativo;
                    lista.produto.Fabricante = (string)resultado.Fabricante;
                    lista.produto.IdProduto = (int)resultado.idProduto;
                    venda.Pedido_Produto.Add(lista);
                }


                ConexaoDAO stmt = new ConexaoDAO();


          



                return venda;
            }
        }


        public void reembolso(Pedido_Produto pedido)
        {
            var query = "update produto set estoque += @quantidade where idProduto = @idProduto";
            con.Open();

            var tran = con.BeginTransaction();
            try
            {
                
                con.Execute(query, new
                {
                    quantidade = pedido.quantidade,
                    idProduto = pedido.produto.IdProduto,
                }, tran);

                query = "update venda set totalBruto -= @PrecoBruto, Totaldedesconto -= @Desconto, TotalLiquido -= (@PrecoLiquido)," +
                        " QuantidadeTotal -= @quantidade, quantidadeunitario-= 1 where idVenda = @idvenda";
                con.Execute(query, new
                {
                    PrecoBruto = pedido.PrecoBruto.GetAsDouble(),
                    Desconto = pedido.Desconto.GetAsDouble(),
                    PrecoLiquido = pedido.PrecoLiquido.GetAsDouble(),
                    quantidade = pedido.quantidade,
                    idvenda = pedido.idVenda,
                }, tran);

                query = "delete from Carrinho where idCarrinho = @idCarrinho";
                con.Execute(query, new
                {
                    idCarrinho = pedido.IdCarrinho,
                }, tran) ;
                tran.Commit();
                con.Close();

            }
            catch (Exception ex)
            {
                tran.Rollback();
                con.Close();
                throw new Exception(ex.Message);
            }
        }


        public void MudarAtivacao(Venda venda)
        {
            try
            {
                var query = "";
                if (venda.Ativo)
                {
                    query = @"Update venda set Ativo = 0 where idVenda = @IdVenda";
                }else
                {
                    query = @"Update venda set Ativo = 1 where idVenda = @idVenda";
                }

                con.Open();
                con.Execute(query, new
                {
                    idVenda = venda.IdVenda,
                });
                con.Close();
            }catch(Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message);
            }
        }

        public List<Pedido_Produto> ListarProdutosDaVendas()
        {
            try
            {
                var query = @"select * from Carrinho";

                con.Open();
                var resultado = con.Query<Pedido_Produto>(query).ToList();
                con.Close();
                return resultado;
            }catch(Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message);
            }
        }

    }
}
