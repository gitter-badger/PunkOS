using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunkOS.HAL.Drivers.Display;
using Cosmos.Debug.Kernel;

namespace PunkOS.System.Manger
{
  public class DisplayManger : DisplayDriver
  {
    private readonly Debugger mDebugger = new Debugger("User", "System.Manger");
    byte[] buffer = new byte[320 * 200];
    public bool didChange = false;

    public DisplayManger() : base()
    {
      mDebugger.Send("DisplayManger booting");
      clear(0);
      mDebugger.Send("DisplayManger booted");
    }

    override public void setPixel(int x, int y, int c)
    {

        buffer[x + (y * 320)] = (byte)c;
        didChange = true;

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

            base.setPixel(x, y, buffer[x + (y * getWidth())]);
            

          }
        }

        clear(0);
      }

    }

    public override void step()
    {
     // mDebugger.Send("DisplayManger Step");
      reDraw();
     // mDebugger.Send("DisplayManger Step Done");
    }
  }
}
