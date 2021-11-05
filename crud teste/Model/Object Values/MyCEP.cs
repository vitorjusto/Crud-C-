using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class MyCEP
    {
        private string _value;
        public MyCEP(string value)
        {
            _value = value;
        }

        public static implicit operator MyCEP(string value)
            => new MyCEP(value);

        public override string ToString()
        {
            return _value;
        }
    }
}
