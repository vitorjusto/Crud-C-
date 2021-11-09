using crud_teste.Validation.Object_Values_Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Object_Values
{
    public class MyTelefone
    {
        private string _value;
        public MyTelefone(string value)
        {
            _value = value.Replace("-", "");
            _value = _value.Replace(" ", "");
        }

        public static implicit operator MyTelefone(string value)
            => new MyTelefone(value);

        public override string ToString()
        {
            return _value;
        }

        public string RetornarFormatado()
        {
            if(_value.Length == 8)
                return string.Format("{0:#### - ####}", long.Parse(_value));
            else
                return "Telefone inválido";
        }
    }
}
