using System;
using System.Linq;

namespace crud_teste.Config.Custom_Controls
{
    class PercentTextBox : DecimalBox
    {
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.Text = ConverterDecimal(this.Text).ToString();
        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);

            string value = new string((from c in this.Text where char.IsDigit(c) || c == ',' || c == '.' || c == '-' select c).ToArray());
            double dvalue = Convert.ToDouble(stringvalida(value) ? value : "0");

            this.Text = dvalue + " %";
        }

        public PercentTextBox()
        {
            Text = 0.0 + " %";
            this.MaxLength = 15;
        }
    }
}
