using crud_teste.Model;
using crud_teste.Model.Listagem;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.DAO
{
    class VendaDAO
    {
        SqlConnection con = new SqlConnection();

        public CarrinhoDAO stmtcarrinho = new CarrinhoDAO();
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


        public List<PedidoListagem> ListarPedidos()
        {
            List<PedidoListagem> pedidos = new List<PedidoListagem>();

            try
            {

                var query = @"select idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda,
                            v.idCliente, v.idColaborador, DescontoAVista, P.Nome as 'NomeCliente', P.Sobrenome as 'sobrenomeCliente',
                            P2.Nome as 'nomeColaborador', P2.Sobrenome as 'sobrenomeColaborador'
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
                    pedido.venda.IdVenda = resultado.idVenda;
                    pedido.venda.TotalBruto = (double)resultado.TotalBruto;
                    pedido.venda.TotalDeDesconto = (double)resultado.TotalDeDesconto;
                    pedido.venda.TotalLiquido = (double)resultado.totalLiquido;
                    pedido.venda.MesesAPrazo = (int)resultado.mesesaprazo;
                    pedido.venda.QuantidadeUnitario = (int)resultado.quantidadeunitario;
                    pedido.venda.QuantidadeDeTotal = (int)resultado.quantidadetotal;
                    pedido.venda.TipoDeVenda = resultado.tipodevenda;
                    pedido.venda.IdCliente = (int)resultado.idCliente;
                    pedido.venda.IdColaborador = resultado.idColaborador;
                    pedido.venda.DescontoAVIsta = (float)resultado.DescontoAVista;
                    pedido.nomeCliente = resultado.NomeCliente;
                    pedido.sobrenomeCliente = resultado.sobrenomeCliente;
                    pedido.nomeColaborador = resultado.NomeColaborador;
                    pedido.SobrenomeColaborador = resultado.sobrenomeColaborador;

                   





                    pedidos.Add(pedido);
                    listaid.Add(pedido.venda.IdVenda);

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
                        if(resultado.idVenda == pedidos[index].venda.IdVenda)
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
                    venda.TotalBruto = (double)reader["TotalBruto"];
                    venda.TotalDeDesconto = (double)reader["TotalDeDesconto"];
                    venda.TotalLiquido = (double)reader["TotalLiquido"];
                    venda.MesesAPrazo = (int)reader["mesesaprazo"];
                    venda.QuantidadeDeTotal = (int)reader["quantidadetotal"];
                    venda.QuantidadeUnitario = (int)reader["quantidadeunitario"];
                    venda.IdCliente = (int)reader["idCliente"];
                    venda.IdColaborador = (int)reader["idColaborador"];
                    venda.DescontoAVIsta = (double)reader["DescontoAVista"];
                    venda.TipoDeVenda = (string)reader["TipoDeVenda"];
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

    }
}
