using Sys = Cosmos.System;
using PunkOS.System.Manger;
using PunkOS.System;
using PunkOS.HAL.Drivers.Display;
using PunkOS.HAL.Drivers;
using PunkOS.HAL;
using System;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using Cosmos.Debug.Kernel;

namespace PunkOS
{
  public class Kernel : Sys.Kernel
  {


    private readonly Debugger mDebugger = new Debugger("User", "Test");

    public DisplayManger screen;

    public MouseDriver mouse;
    public MouseRenderer mr;
    public bool isGUI;

    //private VFSBase myVFS;

    protected override void BeforeRun()
    {
     // mDebugger.Send("Setting up VFS");
     // myVFS = new CosmosVFS();
     // VFSManager.RegisterVFS(myVFS);
      mDebugger.Send("DisplayManger");
      screen = new DisplayManger();
      screen.init();


      mouse = new MouseDriver(screen.getHeight(), screen.getWidth());
      mr = new MouseRenderer(mouse, screen, 3);

    }


    protected override void Run()
    {

      mDebugger.Send("Main");
      Font f = new BaseFont();
      FontManger Font = new FontManger(screen, f, 50);
      Picture p = new Logo();
      PictureManger _Picture = new PictureManger(screen, p);
      int mc = 0;

      while (true)
      {
        mc++;


        Font.renderString(10, 10, "X " + mouse.X().ToString());
        Font.renderString(10, 20, "Y " + mouse.Y().ToString());
        Font.renderString(10, 30, mc.ToString());
        Font.renderString(10, 40, "HELLO WORLD\nTHIS IS ZARLO");
        if (mouse.isLeftClicked())
        {
          Font.renderString(10, 60, "LEFT BUTTON DOWN");
        }
        if (mouse.isRightClicked())
        {
          Font.renderString(10, 60, "RIGHT BUTTON DOWN");
        }
        uint RAMMATH = CPU.GetMemory() / CPU.GetUsedMemoryByKernel();
        Font.renderString(60, 10, "MAX RAM:" + PunkOS.HAL.CPU.GetMemory().ToString());
        Font.renderString(60, 20, "USED RAM:" + PunkOS.HAL.CPU.GetUsedMemoryByKernel().ToString() + " %" + RAMMATH.ToString());



        _Picture.renderPicture(10, 70, "logo");
        _Picture.renderPicture(30, 70, "boo");

        screen.step();

        mr.renderMouse();
        
      }
    }
  }
}
