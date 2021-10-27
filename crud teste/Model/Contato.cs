
using System.Text.RegularExpressions;
namespace crud_teste.Model
{
    public class Contato
    {
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string DDI { get; set; }
        public bool ValidarContato()
        {
            bool valido = false;
            if (!string.IsNullOrEmpty(this.Email))
            {
                if (this.Email.Contains("@") && this.Email.Contains(".com"))
                {
                    valido = true;
                }
            }

            if(new Regex(@"[0-9]{4} - [0-9]{4}").Match(this.Telefone).Success)
            {
                valido = true;
            }

            if (new Regex(@"[0-9]{4} - [0-9]{4}").Match(this.Telefone).Success)
            {
                valido = true;
            }

            if(new Regex(@"\+[0-9]{2}").Match(this.DDI).Success)
            {

                if(new Regex(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").Match(this.Celular).Success)
                {
                    valido = true;
                }
            }

            return valido;
        }

        public Contato()
        {

        }
    }
}
