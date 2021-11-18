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

        public void cadastrar(Venda venda, List<Carrinho> carrinhos)
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
                    DescontoAVista = venda.DescontoAVIsta,
                }
                , tran).ToString());
                
                foreach (var carrinho in carrinhos)
                {
                    carrinho.idVenda = idVenda;
                    con.Execute(querycarrinho, carrinho, tran);
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
                    pedido.venda.TotalBruto.setFromDouble((double)resultado.TotalBruto);
                    pedido.venda.TotalDeDesconto.setFromDouble((double)resultado.TotalDeDesconto);
                    pedido.venda.TotalLiquido.setFromDouble((double)resultado.totalLiquido);
                    pedido.venda.MesesAPrazo = (int)resultado.mesesaprazo;
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

                            Carrinho carrinho = new Carrinho();
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

    }
}
