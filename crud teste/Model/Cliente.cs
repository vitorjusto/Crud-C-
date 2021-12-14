using crud_teste.Model.Object_Values;


namespace CRUD_teste.Model
{
    public class Cliente : Pessoa
    {
        public int idCliente { get; set; }


        public MyDinheiro LimiteDeCompra { get; set; }

        public MyDinheiro LimiteRestante { get; set; }

        public MyDinheiro LimiteAcumulado { get; set; }

        public Cliente()
        {
            LimiteDeCompra = new MyDinheiro();
            LimiteRestante = new MyDinheiro();
        }

        public Cliente(string nome, decimal Limitedecompra)
        {
            Nome = nome;
            LimiteDeCompra = (double)Limitedecompra;
        }

        public void CalcularRestante()
        {
            LimiteRestante = LimiteDeCompra.GetAsDecimal() - LimiteAcumulado.GetAsDecimal();
        }
    }
}
