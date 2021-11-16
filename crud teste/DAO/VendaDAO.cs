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
            con.Open();
            var tran = con.BeginTransaction();
            try
            {
                

                var query = @"Insert Into Venda(TotalBruto, TotalDeDesconto, TotalLiquido, MesesAPrazo, quantidadetotal, quantidadeunitario, tipodevenda, idCliente, idColaborador, DescontoAVista) OUTPUT INSERTED.idVenda Values(@TotalBruto, @TotalDeDesconto, @TotalLiquido, @mesesaprazo, @quantidadedetotal, @quantidadeunitario, @tipodevenda, @idCliente, @IdColaborador, @DescontoAVista)";

                var idVenda = int.Parse(con.ExecuteScalar(query, venda, tran).ToString());
                query = @"Insert Into Carrinho(Quantidade, Desconto, precoBruto, precoliquido, idVenda, idproduto, precodecusto, precodevenda)  Values(@Quantidade, @Desconto, @precoBruto, @precoliquido, @idVenda, @idProduto,  @precodecusto, @precodevenda)";
                
                foreach (var carrinho in carrinhos)
                {
                    carrinho.idVenda = idVenda;
                    con.Execute(query, carrinho, tran);
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
            con.Open();
            try
            {

                var query = @"select idVenda,TotalBruto, TotalDeDesconto, totalLiquido, mesesaprazo, quantidadetotal, quantidadeunitario, tipodevenda,
                            v.idCliente, v.idColaborador, DescontoAVista, P.Nome, P.Sobrenome, P2.Nome, P2.Sobrenome from Venda v
                            Left outer join cliente Cl on Cl.idCliente = v.idCliente Left outer join pessoa P on Cl.IdPessoa = P.idPessoa
                            Left outer join Colaborador Co on Co.idColaborador = v.idColaborador Left outer join pessoa P2 on Co.IdPessoa = P2.idPessoa";
                
                

                var resultado = con.ExecuteReader(query);
                resultado.Read();

                using (resultado)
                {
                    var i = 0;
                    var lista = true;

                    while (lista)
                    {
                        pedidos.Add(new PedidoListagem());
                        pedidos[i].venda.IdVenda = (int)resultado["idVenda"];
                        resultado.NextResult();
                    }
                }

                    con.Close();
                //return resultado.ToList();
                return new List<PedidoListagem>();
            }
            catch (Exception ex)
            {
                con.Close();
                throw new Exception(ex.Message);
            }

        }

    }
}
