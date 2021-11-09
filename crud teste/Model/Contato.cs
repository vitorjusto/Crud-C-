
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using System.Text.RegularExpressions;
namespace crud_teste.Model
{
    public class Contato
    {
        public int idContato { get; set; }
        public string Email { get; set; }

        public MyTelefone Telefone;

        public MyCelular Celular { get; set; }

        

        public Contato()
        {

        }

       
    }
}
