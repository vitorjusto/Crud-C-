using System;
using System.Linq;

namespace crud_teste.Model.Object_Values
{
    public class MyDinheiro
    {
        decimal _value;
        public MyDinheiro(string value)
        {
            var converter = new string((from c in value where char.IsDigit(c) || c == ',' || c == '.' select c).ToArray()); 
            if (string.IsNullOrEmpty(converter))
            {
                _value = 0;
            } else
            {
                _value = Math.Round(decimal.Parse(converter), 2);
            }
        }

        public MyDinheiro(decimal value)
        {
            _value = Math.Round(value, 2);
        }

        

        public MyDinheiro()
        {
            _value = 0.00M;
        }

        public static implicit operator MyDinheiro(string value)
            => new MyDinheiro(value);

        public static implicit operator MyDinheiro(decimal value)
            => new MyDinheiro(value);

        public static implicit operator MyDinheiro(float value)
            => new MyDinheiro(Convert.ToDecimal(value));

        public static implicit operator MyDinheiro(double value)
            => new MyDinheiro((decimal) value);

       

        private double convertToDouble(string value)
        {
            

            return Math.Round(double.Parse(value), 2); 
        }

        private decimal convertToDecimal(string value)
        {


            return Math.Round(decimal.Parse(value), 2);
        }

        public double GetAsDouble()
        {
            return (double)_value;
        }

        public decimal GetAsDecimal()
        {
            return _value;
        }

       
        public string GetAsString()
        {
            return _value.ToString("C2");
        }

        public override string ToString()
        {
            return _value.ToString("C2");
        }

        public void setFromDinheiro(MyDinheiro value)
        {
            _value = value.GetAsDecimal(); 
        }



        public static string SetTextBoxAsMoneyValue(string value)
        {
            value = new string((from c in value where char.IsDigit(c) || c == ',' || c == '.' select c).ToArray());
            double dvalue = Convert.ToDouble(value == "" ? "0" : value);

            return dvalue.ToString("C2");
        }

    }
}
