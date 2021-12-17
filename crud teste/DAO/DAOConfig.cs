using Dapper;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace crud_teste.DAO
{
    public class DAOConfig
    {
        SqlConnection con = new SqlConnection();


        public DAOConfig()
        {
            con.ConnectionString = "Data Source=ESTAGIO1;Initial Catalog=crud;Integrated Security=True";
        }

        public byte[] recuperarSenha()
        {
            try
            {
                con.Open();
                var query = $@"select senha from config;";
                var resultado = con.Query<string>(query).ToList().FirstOrDefault();

                con.Close();
                var resultadoArray = resultado.Split(',');
                byte[] resultadoByte = new byte[16];

                var index = 0;
                foreach(var num in resultadoArray)
                {
                    resultadoByte[index] = byte.Parse(num);
                    index++;
                }


                return resultadoByte;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
