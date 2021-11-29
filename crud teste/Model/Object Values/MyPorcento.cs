

using System;
using System.Linq;

namespace crud_teste.Model.Object_Values
{
    class MyPorcento
    {
        decimal _value;

        public MyPorcento(string value)
        {
            var converter = new string((from c in value where char.IsDigit(c) || c == ',' || c == '.' select c).ToArray());
            if (string.IsNullOrEmpty(converter))
            {
                _value = 0;
            }
            else
            {
                _value = Math.Round(decimal.Parse(converter), 2);
            }
        }

        public MyPorcento(decimal value)
        {
            _value = Math.Round(value, 2);
        }



        public MyPorcento()
        {
            _value = 0.00M;
        }

        public static implicit operator MyPorcento(string value)
            => new MyPorcento(value);

        public static implicit operator MyPorcento(decimal value)
            => new MyPorcento(value);


        public override string ToString()
        {
            return $"{_value} %";
        }

        public decimal ToDecimal()
        {
            return _value;
        }


        public void SetAsDecimal(decimal value)
        {
            _value = value;
        }

        public void SetAsString(string value)
        {
            var dvalue = Convert.ToDecimal(new string((from c in value where char.IsDigit(c) || c == ',' || c == '.' select c).ToArray()));

            _value = Math.Round(dvalue, 2);
        }

    }
}
