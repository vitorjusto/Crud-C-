using crud_teste.DAO;
using crud_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.controller
{
    public class AlterarCarrinho
    {
        public CarrinhoDAO stmt = new CarrinhoDAO();
        public int Salvar(Carrinho carrinho)
        {
            return  stmt.Salvar(carrinho);
            
        }
    }
}
