using crud_teste.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.DAO
{
    public class CarrinhoDAO
    {
        SqlConnection con = new SqlConnection();

        public CarrinhoDAO()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
        }

        public int Salvar(Carrinho carrinho)
        {
            using (con)
            {
                con.Open();
                var tran = con.BeginTransaction();

                try
                {
                    var query = @"insert into Carrinho(Quantidade, Desconto, PrecoBruto, PrecoLiquido, idProduto) OUTPUT INSERTED.idcarrinho values(@Quantidade, @Desconto, @PrecoBruto, @PrecoLiquido, @idProduto)";
                    var idCarrinho = int.Parse(con.ExecuteScalar(query,carrinho , tran).ToString());
                    
                    tran.Commit();
                    con.Close();

                    return idCarrinho;
                }catch(Exception ex)
                {
                    tran.Rollback();
                    con.Close();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
