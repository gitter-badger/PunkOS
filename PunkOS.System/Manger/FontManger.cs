using PunkOS.HAL.Drivers.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.System.Manger
{
    public class FontManger
    {


        private VGADisplayDriver driver;
        private Font font;
        private int stdColor = 2;

        public FontManger(VGADisplayDriver dd, Font f, int sc = 2)
        {
            driver = dd;
            font = f;
            stdColor = sc;
        }

        public void renderChar(int x, int y, char c)
        {
            renderChar(x, y, c, stdColor);
        }

        public void renderString(int x, int y, string text, int gap = 2)
        {
            renderString(x, y, text, stdColor, gap);
        }

        public void renderChar(int x, int y, char c, int color)
        {
            int[] charArray = font.getChar(c);
            for (int i = 0; i < font.fontSize; i++)
            {
                for (int j = 0; j < font.fontSize; j++)
                {
                    if (charArray[(i * font.fontSize) + j] == 1)
                    {
                        driver.setPixel(x + j, y + i, color);
                    }
                }
            }
        }

        public void renderString(int x, int y, string text, int color, int gap = 2, int nlgap = 2)
        {
            int wx = x;
            int wy = y;
            char[] t = text.ToCharArray();
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == '\n')
                {
                    wy += font.fontSize + nlgap;
                    wx = x;
                }
                renderChar(wx, wy, t[i], color);
                wx += gap + font.fontSize;
            }
        }

    }
}
