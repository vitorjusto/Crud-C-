using crud_teste.Model.Object_Values;

namespace crud_teste.Model.Listagem
{
    public class RelatorioProdutosVendaListagem
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }

        public long Quantidade { get; set; }

        public MyDinheiro TotalBruto { get; set; }

        public MyDinheiro Desconto { get; set; }
        public MyDinheiro DescontoAVista { get; set; }

        public MyDinheiro DescontoTotal { get => Desconto.GetAsDecimal() + DescontoAVista.GetAsDecimal(); }
        public MyDinheiro TotalLiquido { get; set; }
        public MyDinheiro TotalCusto { get; set; }

        public MyDinheiro TotalPrecoDeVenda { get; set; }

        public MyPorcento LucroEmPorcento { get => (( TotalLiquido.GetAsDecimal() - TotalCusto.GetAsDecimal()) / TotalCusto.GetAsDecimal()) * 100; }
        public MyDinheiro LucroEmDinheiro { get => TotalLiquido.GetAsDecimal() - TotalCusto.GetAsDecimal(); }//este Lucro desconsidera o desconto a vista

        public bool Ativo { get; set; }

        public RelatorioProdutosVendaListagem()
        {
            TotalBruto = new MyDinheiro();
            Desconto = new MyDinheiro();
            TotalLiquido = new MyDinheiro();
            TotalCusto = new MyDinheiro();
        }
    }
}
