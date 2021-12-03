
using crud_teste.Model.Object_Values;

namespace crud_teste.Model.Listagem
{

    public class RelatorioClienteListagem
    {
        public long idcliente { get; set; }

        public string nome { get; set; }

        public string sobrenome { get; set; }

        public long QuantidadeDeVenda { get; set; }

        public long QuantidadeTotal { get; set; }

        public MyDinheiro TotalBruto { get; set; }

        public MyDinheiro TotalDeDesconto { get; set; }

        public MyDinheiro TotalDedescontoAVista { get; set; }

        public MyDinheiro TotalLiquido { get; set; }

        public MyDinheiro LimiteRestante { get; set; }

        public MyDinheiro PrecoDeCusto { get; set; }
        
        public bool Ativo { get; set; }

        public string NomeCompleto() => nome + " "+ sobrenome;


    }
}
