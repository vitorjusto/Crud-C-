using crud_teste.Model.Object_Values;


namespace CRUD_teste.Model
{
    public class Cliente : Pessoa
    {
        public int idCliente { get; set; }


        public MyDinheiro LimiteDeCompra = new MyDinheiro();

        public Cliente()
        {

        }

        public Cliente(string nome, decimal Limitedecompra)
        {
            Nome = nome;
            LimiteDeCompra = (double)Limitedecompra;
        }

        
    }
}
