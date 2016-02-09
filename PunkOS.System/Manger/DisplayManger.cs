using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunkOS.HAL.Drivers.Display;


namespace PunkOS.System.Manger
{
    public class DisplayManger : DisplayDriver
    {
        byte[] buffer = new byte[320 * 200];
        public bool didChange = false;
        public int changeX, changeY;
        byte[] change = new byte[320 * 200];
        public int changec;

        public DisplayManger() : base()
        {
      clearReal(0);
        }

        override public void setPixel(int x, int y, int c)
        {
            int math = x + y * 320;
      if (getPixel (x, y) != (byte)c)
            {
                changec++;
                buffer[x + (y * 320)] = (byte)c;
                didChange = true;
                change[changec] = (byte)math;
                if (x > changeX)
                    changeX = x + 1;
                if (y > changeY)
                    changeY = y + 1;
            }
        }

        public override byte getPixel(int x, int y)
        {
            return buffer[x + (y * 320)];
        }

        public byte getPixelReal(int x, int y)
        {
            return base.getPixel(x, y);
        }

        public override void clear(int c)
        {
            //  for (int x = 0; x < getWidth(); x++)
            //  {
            //      for (int y = 0; y < getHeight(); y++)
            //      {
            //          if (buffer[x + (y * 320)] != (byte)c)
            //          {
            //              buffer[x + (y * 320)] = (byte)c;
            //              changeX = x;
            //              changeY = y;
            //          }
            //      }
            // }
            //buffer = new byte[0];
            buffer = new byte[320 * 200];

        }

        public void clearReal(int c)
        {
            base.clear(c);
        }

        public void reDraw()
        {
            if (didChange)
            {
                for (int x = 0; x < 320; x++)
                {
          for (int y = 0; y < 200; y++)
          {

            //if (40 != buffer[x + (y * getWidth())]) {

              base.setPixel(x, y, buffer[x + (y * getWidth())]);
            //}

          }
                }
               changeX = 0;
               changeY = 0;
                clear(0);
            }

        }

        public override void step()
        {
            reDraw();
        }
    }
}
