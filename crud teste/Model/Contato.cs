
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
            if (Testar_Se_Email_E_Valido())
            {
                valido = true;
            }

            if(Testar_Se_Telefone_E_Valido())
            {
                valido = true;
            }

           

            if(Testar_Se_DDI_E_Valido())
            {

                if(Testar_Se_Celular_E_Valido())
                {
                    valido = true;
                }
            }

            return valido;
        }

        public Contato()
        {

        }

        public bool Testar_Se_Email_E_Valido()
        {
            if (!string.IsNullOrEmpty(this.Email))
            {
                if (this.Email.Contains("@") && this.Email.Contains(".com"))
                {
                    return true;
                }
            }
            return false;
        }

        public bool Testar_Se_Telefone_E_Valido()
        {

            if(!string.IsNullOrEmpty(this.Telefone))
            {
                return new Regex(@"[0-9]{4} - [0-9]{4}").Match(this.Telefone).Success;
            }
            return false;
        }

        public bool Testar_Se_DDI_E_Valido()
        {
            
            if (!string.IsNullOrEmpty(this.DDI))
            {
                return new Regex(@"\+[0-9]{2}").Match(this.DDI).Success;
            }
            return false;
        }

        public bool Testar_Se_Celular_E_Valido()
        {

            if (!string.IsNullOrEmpty(this.Celular))
            {
                return new Regex(@"\([0-9]{2}\) 9[0-9]{3} - [0-9]{4}").Match(this.Celular).Success;
            }
            return false;
        }
    }
}
