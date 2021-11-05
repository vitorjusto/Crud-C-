using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model.Object_Values
{
    public class MyCelular
    {
        public string Celular { get; set; }
        public string DDI { get; set; }
        public MyCelular(string celular )
        {
            Celular = celular;
        }

        public static implicit operator MyCelular(string value)
            => new MyCelular( value);


        public override string ToString()
        {
            return DDI + " " + Celular;
        }
    }
}
