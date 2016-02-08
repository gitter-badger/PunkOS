using PunkOS.HAL.Drivers.Display;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.System.Manger
{
    public class PictureManger
    {


        private VGADisplayDriver driver;
        private Picture Picture;

        public PictureManger(VGADisplayDriver dd, Picture f)
        {
            driver = dd;
            Picture = f;
        }


        public void renderPicture(int x, int y, string c)
        {
            int[] charArray = Picture.getPicture(c);
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
