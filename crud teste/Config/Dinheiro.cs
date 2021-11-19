using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace crud_teste.Config
{
    public static class Dinheiro
    {

        public static string  converterParaDinheiro(string value)
        {
            var converter = value.Replace("R$", "");
           
            if (string.IsNullOrEmpty(converter))
            {
                return 0.ToString("C2");
            }
            else if(new Regex(@"([0-9]+),([0-9]+)").IsMatch(converter) || new Regex(@"([0-9]+)").IsMatch(converter))
            {
                return Math.Round(double.Parse(converter), 2).ToString("C2");
            }else if(new Regex(@"([0-9]+),").IsMatch(converter))
            {
                converter = converter + "00";
                return Math.Round(double.Parse(converter), 2).ToString("C2");
            }
            else
            {
                return 0.ToString("C2");
            }
        }

        public static decimal ConverterParaDecimal(string value)
        {
            var converter = value.Replace("R$", "");

            if (string.IsNullOrEmpty(converter))
            {
                return 0;
            }
            else if (new Regex(@"([0-9]+),([0-9]+)").IsMatch(converter))
            {
                return Math.Round(decimal.Parse(converter), 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
