using crud_teste.Model.Object_Values;
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
        public MyDinheiro TotalBruto = new MyDinheiro();
        public MyDinheiro TotalDeDesconto = new MyDinheiro();
        public MyDinheiro TotalLiquido = new MyDinheiro();
        public int MesesAPrazo{ get; set; }
        public int QuantidadeDeTotal{ get; set; }
        public int QuantidadeUnitario{ get; set; }
        public string TipoDeVenda{ get; set; }

        public float DescontoAVIsta { get; set; }

        public int IdCliente { get; set; }
        public int IdColaborador { get; set; }

    }
}
