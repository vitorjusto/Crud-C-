using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Object_Values
{
    public class MyCelular
    {
        private string _Celular { get; set; }

        private List<string> TirarCaracteres = new List<string> { "(", ")", " ", "-", "+" };
        private string _DDI { get; set; }

        public string Celular { get { return RetornarCelularComFormatacao(); }
            

            set {
                 _Celular = value;
                foreach(var x in TirarCaracteres)
                {
                    _Celular = _Celular.Replace(x, "");
                }
                    
                } }
        public string DDI { get { return RetornarDDIComFormatacao(); } set { _DDI = value.Replace("+", ""); } }
        public MyCelular(string celular )
        {
            Celular = celular;
        }

        public static implicit operator MyCelular(string value)
            => new MyCelular( value);

        public string RetornarCelular()
        {
            return _Celular;
        }
        
        public string RetornarDDI()
        {
            return _DDI;
        }


        public string RetornarCelularComFormatacao()
        {
            if (!string.IsNullOrEmpty(RetornarCelular()))
                return string.Format("{0:(##) #### - ####}", long.Parse(_Celular));
            else
                return "Celular Inválida";
        }

        public string RetornarDDIComFormatacao()
        {

            if (!string.IsNullOrEmpty(RetornarDDI()))
                return string.Format("{0:+##}", int.Parse(_DDI));
            else
                return "DDI Inválida";
        }
    }
}
