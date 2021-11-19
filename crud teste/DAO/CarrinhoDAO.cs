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

        public void Salvar(Pedido_Produto carrinho)
        {
            using (con)
            {
                con.Open();

                try
                {
                    
                    con.Close();

                }
                catch(Exception ex)
                {
                    con.Close();
                    throw new Exception(ex.Message);
                }
            }
        }
    }
}
