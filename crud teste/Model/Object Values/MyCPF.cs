using crud_teste.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class MyCPF
    {
        private string _value;
        public MyCPF(string value)
        {
            _value = value.Replace("-", "");
            _value = _value.Replace(",", "");
        }

        public static implicit operator MyCPF(string value)
            => new MyCPF(value);

        public override string ToString()
        {
            return _value;
        }

        public string RetornarFormatado()
        {
            
            if (_value.Length == 11)
                return long.Parse(_value).ToString(@"000\,000\,000\-00");
            else
                return "CPF Inválido";
        }
    }
}
