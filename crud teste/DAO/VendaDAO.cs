using crud_teste.Model;
using crud_teste.Model.Listagem;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


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


            var query = @"Insert Into Venda(TotalBruto, TotalDeDesconto, TotalLiquido, MesesAPrazo, quantidadetotal, quantidadeunitario, tipodevenda, idCliente, idColaborador, DescontoAVista) OUTPUT INSERTED.idVenda 
                          Values(@TotalBruto, @TotalDeDesconto, @TotalLiquido, @mesesaprazo, @quantidadedetotal, @quantidadeunitario, @tipodevenda, @idCliente, @IdColaborador, @DescontoAVista)";
            var querycarrinho = @"Insert Into Carrinho(Quantidade, Desconto, precoBruto, precoliquido, idVenda, idproduto, precodecusto, precodevenda)  Values(@Quantidade, @Desconto, @precoBruto, @precoliquido, @idVenda, @idProduto,  @precodecusto, @precodevenda)";
            var queryproduto = @"update Produto set Estoque -= @Quantidade where idProduto = @IdProduto";
            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                
                var idVenda = int.Parse(con.ExecuteScalar(query, new {
                    TotalBruto = venda.TotalBruto.GetAsDouble(),
                    TotalDeDesconto = venda.TotalDeDesconto.GetAsDouble(),
                    TotalLiquido = venda.TotalLiquido.GetAsDouble(),
                    mesesaprazo = venda.MesesAPrazo,
                    quantidadedetotal = venda.QuantidadeDeTotal,
                    quantidadeunitario = venda.QuantidadeUnitario,
                    tipodevenda = venda.TipoDeVenda,
                    idCliente = venda.IdCliente,
                    IdColaborador = venda.IdColaborador,
                    DescontoAVista = venda.DescontoAVIsta.GetAsDouble(),
                }
                , tran).ToString());
                
                foreach (var carrinho in venda.Pedido_Produto)
                {
                    carrinho.idVenda = idVenda;
                    con.Execute(querycarrinho, new
                    {
                        Quantidade = carrinho.quantidade,
                        Desconto = carrinho.Desconto.GetAsDouble(),
                        precoBruto = carrinho.PrecoBruto.GetAsDouble(),
                        precoLiquido = carrinho.PrecoLiquido.GetAsDouble(),
                        idVenda = carrinho.idVenda,
                        idProduto = carrinho.idProduto,
                        precodecusto = carrinho.precoDeCusto.GetAsDouble(),
                        precodevenda = carrinho.precoDeVenda.GetAsDouble()
                    }, tran) ;
                    con.Execute(queryproduto, new
                    {
                        Quantidade = carrinho.quantidade,
                        IdProduto = carrinho.idProduto,

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

        internal void SalvarVenda(Venda venda)
        {
            var query = "update venda set TotalBruto = @TotalBruto, TotalDeDesconto = @TotalDeDesconto, TotalLiquido = @TotalLiquido, " +
                "mesesaprazo = @MesesAPrazo, quantidadetotal = @quantidadetotal, quantidadeunitario = @quantidadeunitario, TipoDeVenda = @TipoDeVenda, " +
                "idCliente = @idCliente, idColaborador = @idColaborador, DescontoAVista = @DescontoAVista where idVenda = @idVenda";

            var queryPedido_Produto = "update Carrinho set Quantidade = @quantidade, Desconto = @desconto, precoBruto = @precoBruto, precoLiquido = @precoLiquido, " +
                "PrecoDeCusto = @precoDeCusto, PrecoDeVenda = @PrecoDeVenda where idVenda = @idVenda";

            var querycarrinho = @"Insert Into Carrinho(Quantidade, Desconto, precoBruto, precoliquido, idVenda, idproduto, precodecusto, precodevenda)  
                                Values(@Quantidade, @Desconto, @precoBruto, @precoliquido, @idVenda, @idProduto,  @precodecusto, @precodevenda)";

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
                    DescontoAVista = venda.DescontoAVIsta.GetAsDouble(),
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
                            idVenda = pedido.idVenda,
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
            List<PedidoListagem> pedidos = new List<PedidoListagem>();

            try
            {

                var query = @"select idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda,
                            v.idCliente, v.idColaborador, DescontoAVista, P.Nome as 'NomeCliente', P.Sobrenome as 'sobrenomeCliente',
                            P2.Nome as 'nomeColaborador', P2.Sobrenome as 'sobrenomeColaborador', v.ativo
                            from Venda v
                            Left outer join cliente Cl on Cl.idCliente = v.idCliente Left outer join pessoa P on Cl.IdPessoa = P.idPessoa
                            Left outer join Colaborador Co on Co.idColaborador = v.idColaborador Left outer join pessoa P2 on Co.IdPessoa = P2.idPessoa";



                con.Open();
                var resultados = con.Query<dynamic>(query);
                con.Close();


                var listaid = new List<int>();
                
                foreach(var resultado in resultados)
                {
                    PedidoListagem pedido = new PedidoListagem();
                    pedido.IdVenda = resultado.idVenda;
                    pedido.TotalBruto = (double)resultado.TotalBruto;
                    pedido.TotalDeDesconto = (double)resultado.TotalDeDesconto;
                    pedido.TotalLiquido = (double)resultado.totalLiquido;
                    pedido.MesesAPrazo = (int)resultado.mesesaprazo;
                    pedido.TipoDeVenda = resultado.tipodevenda;
                    pedido.IdCliente = (int)resultado.idCliente;
                    pedido.IdColaborador = resultado.idColaborador;
                    pedido.DescontoAVIsta = (float)resultado.DescontoAVista;
                    pedido.nomeCliente = resultado.NomeCliente;
                    pedido.sobrenomeCliente = resultado.sobrenomeCliente;
                    pedido.nomeColaborador = resultado.NomeColaborador;
                    pedido.SobrenomeColaborador = resultado.sobrenomeColaborador;
                    pedido.QuantidadeTotal = (long)resultado.quantidadetotal;
                    pedido.QuantidadeUnitaria = (long)resultado.quantidadeunitario;
                    pedido.ativo = (bool)resultado.ativo;





                    pedidos.Add(pedido);
                    listaid.Add(pedido.IdVenda);

                }



                query = "select * from Carrinho where idVenda in @listaid";

                con.Open();
                resultados = con.Query<dynamic>(query, new
                {
                    listaid = listaid.ToArray()
                }
                );
                
                con.Close();

                var index = 0;

                while(index < pedidos.Count())
                {
                    foreach(var resultado in resultados)
                    {
                        if(resultado.idVenda == pedidos[index].IdVenda)
                        {

                            Pedido_Produto carrinho = new Pedido_Produto();
                            carrinho.Desconto = (float)resultado.Desconto;
                            carrinho.quantidade = (int)resultado.Quantidade;
                            carrinho.PrecoBruto = (float)resultado.precobruto;
                            carrinho.PrecoLiquido = (float)resultado.precoliquido;
                            carrinho.idProduto = (int)resultado.idProduto;
                            carrinho.idVenda = (int)resultado.idVenda;
                            carrinho.precoDeCusto = (float)resultado.PrecoDeCusto;
                            carrinho.precoDeVenda = (float)resultado.PrecoDeVenda;
                            carrinho.IdCarrinho = (int)resultado.IdCarrinho;
                            pedidos[index].carrinhos.Add(carrinho);
                        }

                        
                    }
                    index++;
                }



                return pedidos;
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
                    venda.IdCliente = (int)reader["idCliente"];
                    venda.IdColaborador = (int)reader["idColaborador"];
                    venda.DescontoAVIsta = (double)reader["DescontoAVista"];
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
                    lista.idProduto = (int)resultado.idProduto;
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

    }
}
