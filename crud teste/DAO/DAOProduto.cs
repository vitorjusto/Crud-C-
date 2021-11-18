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

                var query = $@"select idproduto, nomeProduto, precodevenda, descontoavista, fabricante, estoque from produto where {queryWhere}";
                var resultado = con.Query<ProdutoListagem>(query);
                return resultado.ToList();

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
                    produto.PrecoDeCusto.setFromDouble(double.Parse(reader["PrecoDeCusto"].ToString()));
                    produto.PrecoDeVenda.setFromDouble(double.Parse(reader["Precodevenda"].ToString()));
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


                    var query = @"update Produto set NomeProduto = @NomeDoProduto, CodigoDeBarras = @CodigoDeBarras, DescontoAVista = @DescontoAVista, precodecusto = @PrecoDeCusto, Estoque = @Estoque, Fabricante= @Fabricante, Ativo = @Ativo where idProduto = @IdProduto";

                    con.Execute(query, new
                    {
                        CodigoDeBarras = produto.CodigoDeBarras,
                        NomeDoProduto = produto.NomeDoProduto,
                        PrecoDeVenda = produto.PrecoDeVenda.GetAsDouble(),
                        PrecoDeCusto = produto.PrecoDeCusto.GetAsDouble(),
                        Estoque = produto.Estoque,
                        Ativo = produto.Ativo,
                        Fabricante = produto.Fabricante,


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
    }
}      