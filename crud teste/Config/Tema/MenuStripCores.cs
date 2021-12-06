using System.Drawing;
using System.Windows.Forms;

namespace Tema
{
    public class CoresStrip : ProfessionalColorTable
    {



        public Color itemColor;

        public CoresStrip(Color cor)
        {
            itemColor = cor;
        }
        public override Color MenuStripGradientBegin
        {
            get
            {
                return itemColor;
            }

        }

        public override Color MenuStripGradientEnd
        {
            get
            {
                return itemColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Temas.FontColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return itemColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Temas.FontColor;
            }
        }

        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return itemColor;
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return itemColor;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return itemColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return itemColor;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return itemColor;
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return itemColor;
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return itemColor;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return itemColor;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return itemColor;
            }
        }


    }
}
