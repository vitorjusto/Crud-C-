using crud_teste.Config.Custom_Controls;
using System.Drawing;
using System.Windows.Forms;

namespace Tema
{
    public static class Temas
    {

        public static Color MainColor = Color.AliceBlue; //backGround
        public static Color FontColor = Color.Black;
        public static Color Strip = Color.LightBlue;
        public static Color TextBoxBackColor = Color.White;
        public static Color GroupBoxBackColor = Color.FromArgb(245, 247, 247);
        public static Color LinkColor = Color.Blue;

        public static Color Positive = Color.Green;
        public static Color Negative = Color.Red;
        public static string Tema { get; set; }

        public static void AlterarTema(string tema)
        {
            Tema = tema;
            if (Tema.Equals("Dark"))
            {
                MainColor = Color.FromArgb(38, 38, 38);
                FontColor = Color.FromArgb(230, 230, 230);
                Strip = Color.FromArgb(50, 50, 50);
                TextBoxBackColor = Color.FromArgb(70, 70, 70);
                GroupBoxBackColor = Color.FromArgb(40, 40, 40);

                LinkColor = Color.LightBlue;

                Positive = Color.LightGreen;
                Negative = Color.FromArgb(255, 77, 77);
            }
            else if (Tema.Equals("Standard"))
            {
                MainColor = Color.AliceBlue;
                FontColor = Color.Black;
                Strip = Color.LightBlue;
                TextBoxBackColor = Color.White;
                GroupBoxBackColor = Color.FromArgb(245, 247, 247);


                Positive = Color.Green;
                Negative = Color.Red;

            }
            else if (Tema.Equals("Sunset"))
            {
                MainColor = Color.FromArgb(255, 153, 51);
                FontColor = Color.Black;
                Strip = Color.FromArgb(255, 87, 26);
                TextBoxBackColor = Color.FromArgb(255, 204, 153);
                GroupBoxBackColor = Color.Orange;


                Positive = Color.FromArgb(0, 100, 0);
                Negative = Color.Red;
            }
            else if (Tema.Equals("Sea"))
            {
                MainColor = Color.FromArgb(64, 143, 124);
                FontColor = Color.Black;
                Strip = Color.FromArgb(84, 158, 65);
                TextBoxBackColor = Color.FromArgb(66, 146, 168);
                GroupBoxBackColor = Color.FromArgb(91, 166, 114);



                Positive = Color.LightGreen;
                Negative = Color.FromArgb(200, 0, 0);
            }
            else if (Tema.Equals("Neutral"))
            {
                MainColor = Color.FromArgb(128, 128, 128);
                FontColor = Color.Black;
                Strip = Color.FromArgb(102, 102, 102);
                TextBoxBackColor = Color.FromArgb(204, 204, 204);
                GroupBoxBackColor = Color.FromArgb(140, 140, 140);


                Positive = Color.Green;
                Negative = Color.Red;
            }
            else if (Tema.Equals("Blue"))
            {
                MainColor = Color.FromArgb(0, 18, 99);
                FontColor = Color.FromArgb(230, 230, 230);
                Strip = Color.FromArgb(2, 25, 75);
                TextBoxBackColor = Color.FromArgb(50, 50, 150);
                GroupBoxBackColor = Color.FromArgb(0, 30, 90);


                Positive = Color.LightGreen;
                Negative = Color.FromArgb(255, 150, 150);
            }
        }
        private static void SetDataGridTema(DataGridView control)
        {
            control.BackgroundColor = MainColor;
            control.BorderStyle = BorderStyle.None;
            control.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            control.EnableHeadersVisualStyles = false;
            control.ColumnHeadersDefaultCellStyle.BackColor = Strip;
            control.ColumnHeadersDefaultCellStyle.ForeColor = FontColor;
            control.ColumnHeadersDefaultCellStyle.SelectionBackColor = Strip;
            control.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            control.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //control.RowsDefaultCellStyle.BackColor = TextBoxBackColor;
            //control.RowsDefaultCellStyle.ForeColor = FontColor;

            control.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            control.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            control.AllowUserToAddRows = false;
            control.AllowUserToDeleteRows = false;
            control.AllowUserToResizeRows = false;
            control.AllowUserToResizeColumns = false;
            control.ReadOnly = true;
            control.RowHeadersVisible = false;
        }

        private static void SetComboBoxTema(ComboBox control)
        {
            if (!control.Name.Equals("CobTema"))
                control.SelectedIndex = 0;
            control.ForeColor = FontColor;
            control.BackColor = TextBoxBackColor;

            if (Tema.Equals("Standard"))
                control.FlatStyle = FlatStyle.System;
            else
                control.FlatStyle = FlatStyle.Flat;

        }

        private static void SetTextBoxTema(TextBox control)
        {
            control.ForeColor = FontColor;
            control.BackColor = TextBoxBackColor;
            control.BorderStyle = BorderStyle.FixedSingle;

            if(control is MoneyTextBox)
            {
                SetMoneyBoxTema((MoneyTextBox)control);
            }
        }

        private static void SetMoneyBoxTema(MoneyTextBox control)
        {
            control.Negative = Negative;
            control.Positive = Positive;
            control.Zero = FontColor;
        }
        private static void SetMaskedTextBoxTema(MaskedTextBox control)
        {
            control.ForeColor = FontColor;
            control.BackColor = TextBoxBackColor;
            control.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void SetNumeicUpDownTema(NumericUpDown control)
        {
            control.ForeColor = FontColor;
            control.BackColor = TextBoxBackColor;
            control.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void SetMenuStripTema(MenuStrip control)
        {

            control.BackColor = Strip;
            control.ForeColor = FontColor;

            control.RenderMode = ToolStripRenderMode.Professional;
            control.Renderer = new ToolStripProfessionalRenderer(new CoresStrip(TextBoxBackColor));

            foreach (var item in control.Items)
            {
                SetMenuStripTema((ToolStripMenuItem)item);
            }

        }

        private static void SetMenuStripTema(ToolStripMenuItem control)
        {
            foreach (var items in control.DropDownItems)
                SetMenuStripDropDownItems((ToolStripDropDownItem)items);

        }
        private static void SetGroupBoxTema(GroupBox control)
        {
            control.ForeColor = FontColor;
            control.BackColor = GroupBoxBackColor;

            for (int i = 0; i < control.Controls.Count; i++)
            {
                AlterarTemaSozinho(control.Controls[i]);
            }

        }

         private static void SetMenuStripDropDownItems(ToolStripDropDownItem control)
         {
            control.ForeColor = FontColor;
         }




        public static void AlterarTemaSozinho(Control control)
        {
            if (control is MenuStrip)
            {
                SetMenuStripTema((MenuStrip)control);
            }
            else if (control is Label)
            {
                control.ForeColor = FontColor;
            }
            else if (control is CheckBox)
            {
                control.ForeColor = FontColor;
            }
            else if (control is GroupBox)
            {
                SetGroupBoxTema((GroupBox)control);
            }
            else if (control is DataGridView)
            {
                SetDataGridTema((DataGridView)control);
            }
            else if (control is ComboBox)
            {
                SetComboBoxTema((ComboBox)control);
            }
            else if (control is TextBox)
            {
                SetTextBoxTema((TextBox)control);
            }
            else if (control is MaskedTextBox)
            {
                SetMaskedTextBoxTema((MaskedTextBox)control);
            }
            else if (control is NumericUpDown)
            {
                SetNumeicUpDownTema((NumericUpDown)control);
            }
        }

        public static void AtribuirTema(Control controls)
        {
            if (string.IsNullOrEmpty(Tema))
                Tema = "Standard";

            controls.BackColor = MainColor;
            for (int i = 0; i < controls.Controls.Count; i++)
            {
                AlterarTemaSozinho(controls.Controls[i]);
            }
        }
    }

}