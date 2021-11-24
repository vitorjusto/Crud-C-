using crud_teste.Model.Object_Values;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class Venda
    {
        public int IdVenda { get; set; }
        public MyDinheiro TotalBruto {
            get => Pedido_Produto.Sum(x => x.PrecoBruto.GetAsDouble());
        }
        public MyDinheiro TotalDeDesconto {

            get => Pedido_Produto.Sum(x => x.Desconto.GetAsDouble());
        }
        public MyDinheiro TotalLiquido {
            get => Pedido_Produto.Sum(x => x.PrecoLiquido.GetAsDouble());
        }
        public int MesesAPrazo{ get; set; }
        public long QuantidadeDeTotal{ get => Pedido_Produto.Sum(x => x.quantidade); }
        public int QuantidadeUnitario{ get => Pedido_Produto.Count; }
        public string TipoDeVenda{ get; set; }

        public MyDinheiro DescontoAVIsta = new MyDinheiro();

        public List<Pedido_Produto> Pedido_Produto = new List<Pedido_Produto>();


        public Cliente cliente = new Cliente();

        public Colaborador colaborador = new Colaborador();

       public bool Ativo { get; set; }


        

        

    }
}
