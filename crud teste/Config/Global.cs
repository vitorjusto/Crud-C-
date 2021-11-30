using System.Drawing;
using System.Windows.Forms;

namespace crud_teste
{
    public class Global
    {

        public static Color BackgroundColor = Color.AliceBlue;
        public static Color FontColor = Color.Black;
        public static Color Strip = Color.LightBlue;
        public static Color TextBoxBackColor = Color.White;

        public static bool teste()
        {
            return true;
        }

        public static bool isNotIntChar(char c)
        {
            if(char.IsDigit(c) || c.ToString() == "\b")
            {
                return false;
            }else
            {
                return true;
            }
        }

        public static bool isNotIntText(char c, string text)
        {
            if (char.IsDigit(c) && (text.Length) < 10)
            {
                return false;
            }
            else if(c.ToString() == "\b" && text.Length <= 10)
            {
                return false;
            }
            return true;
        }

        public static bool isNotFloatText(char c, string text)
        {
            if (char.IsDigit(c) || c.ToString() == "\b" || (c.ToString() == "," && !text.Contains(",")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AlterarTema(bool escuro)
        {
            if (escuro)
            {
                BackgroundColor = Color.FromArgb(38, 38, 38);
                FontColor = Color.White;
                Strip = Color.FromArgb(64, 64, 64);
                TextBoxBackColor = Color.FromArgb(89, 89, 89);

            }
            else
            {
                BackgroundColor = Color.AliceBlue;
                FontColor = Color.Black;
                Strip = Color.LightBlue;
                TextBoxBackColor = Color.White;
            }
        }
        

        public static void AlterarTemaSozinho(Control control)
        {
            if(control is MenuStrip)
            {
                control.BackColor = Strip;
                control.ForeColor = FontColor;
            }else if(control is Label)
            {
                control.ForeColor = FontColor;
            }else if(control is CheckBox)
            {
                control.ForeColor = FontColor;
            }else if(control is GroupBox)
            {
                control.ForeColor = FontColor;
                
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    AlterarTemaSozinho(control.Controls[i]);
                }

            }
            else if(control is TextBox || control is MaskedTextBox || control is ComboBox || control is DateTimePicker || control is NumericUpDown)
            {
                control.ForeColor = FontColor;
                control.BackColor = TextBoxBackColor;
            }
        }

        public static void AtribuirTema(Control controls)
        {
            controls.BackColor = BackgroundColor;

            for(int i = 0; i < controls.Controls.Count; i++)
            {
                AlterarTemaSozinho(controls.Controls[i]);
            }
        }
    }
}
