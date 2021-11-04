using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_teste.Model
{
    public class Cliente : Pessoa
    {
        public int idCliente { get; set; }


        public decimal LimiteDeCompra { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, decimal Limitedecompra)
        {
            Nome = nome;
            LimiteDeCompra = Limitedecompra;
        }

        public void ValidarCliente()
        {
            



        }
    }
}
