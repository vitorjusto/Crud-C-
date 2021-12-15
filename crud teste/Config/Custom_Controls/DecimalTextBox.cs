using System;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.Config.Custom_Controls
{
    class DecimalBox : TextBox
    {
        public decimal Value { get => ConverterDecimal(this.Text); set => this.Text = value.ToString(); }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar.ToString() == "\b" || (e.KeyChar.ToString() == "," && !this.Text.Contains(",") || (e.KeyChar.ToString() == "-" && !this.Text.Contains("-"))));
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (this.Text.Contains("-") && this.Text.IndexOf('-') != 0)
                this.Text = this.Text.Replace("-", "");

        }

        protected decimal ConverterDecimal(string value)
        {
            var converter = new string((from c in this.Text where char.IsDigit(c) || c == ',' || c == '.' || c == '-' select c).ToArray());
            if (string.IsNullOrEmpty(converter))
            {
                return 0.00M;
            }
            else
            {
                return Math.Round(decimal.Parse(stringvalida(converter) ? converter : "0.0"), 2);
            }
        }

        protected bool stringvalida(string value)
        {
            if (value == "-" || value == "," || value == ".")
                return false;
            else if (value.Contains("-,") || value.Contains("-."))
                return false;

            return true;
        }


    }
}
