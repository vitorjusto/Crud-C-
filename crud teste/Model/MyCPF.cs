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
            _value = value;
        }

        public static implicit operator MyCPF(string value)
            => new MyCPF(value);

        public override string ToString()
        {
            return _value;
        }
    }
}
