using Cosmos.Debug.Kernel;
using Cosmos.HAL;
using SHAL = Cosmos.HAL;

namespace PunkOS.HAL.Drivers.Display
{
  public class DisplayDriver 
  {
    private readonly Debugger mDebugger = new Debugger("User", "HAL");
    protected VGAScreen screen;

    private int width, height;

    public DisplayDriver()
    {
      screen = new VGAScreen();
    }

    public void init()
    {
      mDebugger.Send("Setting up DisplayDriver");
      screen.SetGraphicsMode(VGAScreen.ScreenSize.Size320x200, VGAScreen.ColorDepth.BitDepth8);
      screen.Clear(0);
      width = screen.PixelWidth;
      height = screen.PixelHeight;
      mDebugger.Send("Set up DisplayDriver");
    }

    public virtual void setPixel(int x, int y, int c)
    {
      if (screen.GetPixel320x200x8((uint)x, (uint)y) != (uint)c)
        screen.SetPixel320x200x8((uint)x, (uint)y, (uint)c);
    }

    public virtual byte getPixel(int x, int y)
    {
      return (byte)screen.GetPixel320x200x8((uint)x, (uint)y);
    }

    public virtual void clear()
    {
      clear(0);
    }

    public virtual void clear(int c)
    {
      screen.Clear(c);
    }

    public virtual void Exit()
    {

    }

    public virtual void step() { }

    public int getWidth()
    {
      return width;
    }

    public int getHeight()
    {
      return height;
    }
  }
}

