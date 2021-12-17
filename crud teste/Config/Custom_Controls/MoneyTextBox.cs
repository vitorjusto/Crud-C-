using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Config.Custom_Controls
{
    class MoneyTextBox : DecimalBox
    {
        public bool StyleText { get; set; }

        public Color Positive { get; set; }
        public Color Negative { get; set; }
        public Color Zero { get; set; }
        

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if(!this.ReadOnly)
                this.Text = ConverterDecimal(this.Text).ToString();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            string value = new string((from c in this.Text where char.IsDigit(c) || c == ',' || c == '.' || c == '-' select c).ToArray());
            double dvalue = Convert.ToDouble(stringvalida(value) ? value : "0");

            this.Text = dvalue.ToString("C2");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (StyleText)
            {
                if (PegarValorEmDecimal() < 0.0M)
                    this.ForeColor = Negative;
                else if (PegarValorEmDecimal() > 0.0M)
                    this.ForeColor = Positive;
                else
                    this.ForeColor = Zero;
            }

            if (this.Text.Contains("-") && this.Text.IndexOf('-') != 0)
                this.Text = this.Text.Replace("-", "");
        }

        public MoneyTextBox()
        {
            Text = 0.0.ToString("C2");

            Positive = Color.Green;
            Negative = Color.Red;
            Zero = Color.Black;

            this.MaxLength = 15;
        }
    }
}
