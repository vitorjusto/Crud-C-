using System;


namespace crud_teste.Model.Object_Values
{
    public class MyDinheiro
    {
        double _value;
        public MyDinheiro(string value)
        {
            var converter = value.Replace("R$ ", "");
            if (string.IsNullOrEmpty(converter))
            {
                _value = 0;
            } else
            {
                _value = Math.Round(double.Parse(converter), 2);
            }
        }

        public MyDinheiro(double value)
        {
            _value = Math.Round(value, 2);
        }

        

        public MyDinheiro()
        {
            _value = 0.00;
        }

        public static implicit operator MyDinheiro(string value)
            => new MyDinheiro(value);

        public static implicit operator MyDinheiro(double value)
            => new MyDinheiro(value);

       

        private double convertToDouble(string value)
        {
            

            return Math.Round(double.Parse(value), 2); 
        }

        public double GetAsDouble()
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
            _value = value.GetAsDouble(); 
        }


        public void Increment(double value)
        {
            _value += value;
        }
        public void Increment(string value)
        {
            var dvalue = convertToDouble(value);
            _value += dvalue;
        }

        public void Increment(MyDinheiro value)
        {
            _value += value.GetAsDouble();
        }

        public void Decrement(double value)
        {
            _value -= value;
        }
        public void Decrement(string value)
        {
            var dvalue = convertToDouble(value);
            _value -= dvalue;
        }

        public void Decrement(MyDinheiro value)
        {
            _value += value.GetAsDouble();
        }
    }
}
