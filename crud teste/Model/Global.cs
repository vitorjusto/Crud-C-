﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public static bool isIntChar(char c)
        {
            if(char.IsDigit(c) || c.ToString() == "\b")
            {
                return false;
            }else
            {
                return true;
            }

        }

        public static bool isFloatText(char c, string text)
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
