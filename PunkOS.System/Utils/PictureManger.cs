using PunkOS.HAL.Drivers.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.System.Utils
{
    public class PictureManger
    {


        private DisplayDriver driver;
        private Picture Picture;

        public PictureManger(DisplayDriver dd, Picture f)
        {
            driver = dd;
            Picture = f;
        }


        public void renderPicture(int x, int y, string pic)
        {
            int[] charArray = Picture.getPicture(pic);
            for (int i = 0; i < Picture.Size; i++)
            {
                for (int j = 0; j < Picture.Size; j++)
                {
                    
                        driver.setPixel(x + j, y + i, charArray[(i * Picture.Size) + j]);
                    
                }
            }
        }


    }
}
