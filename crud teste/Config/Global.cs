using System.Drawing;
namespace crud_teste
{
    public class Global
    {

        public static Color BackgroundColor = Color.AliceBlue;
        public static Color FontColor = Color.Black;
        public static Color Strip = Color.LightBlue;

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
    }
}
