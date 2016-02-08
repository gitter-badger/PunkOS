using Sys = Cosmos.System;
using PunkOS.System.Manger;
using PunkOS.System;
using PunkOS.HAL.Drivers.Display;
using PunkOS.HAL.Drivers;
using PunkOS.HAL;
using System;


namespace PunkOS
{
    public class Kernel : Sys.Kernel
    {

       // public VGADisplayDriver screen;

       // public MouseDriver mouse;
       // public MouseRenderer mr;
        public bool isGUI;
        protected override void BeforeRun()
        {           
         //   screen = new VGADisplayManger();
         //   screen.init();
      

         //   mouse = new MouseDriver(screen.getHeight(), screen.getWidth());
         //   mr = new MouseRenderer(mouse, screen, 3);
        }


        protected override void Run()
        {

      //Font f = new BaseFont();
      //      FontManger Font = new FontManger(screen, f, 50);
      //      Picture p = new Logo();
      //      PictureManger _Picture = new PictureManger(screen, p);
      //      int mc = 0;
      Console.Clear();
      Console.WriteLine("PunkOS");
            while (true)
            {
        //      mc++;

        System.Manger.CommandManger.runCommand(Console.ReadLine());  

        //        Font.renderString(10, 10, "X " + mouse.X().ToString());
        //        Font.renderString(10, 20, "Y " + mouse.Y().ToString());
        //        Font.renderString(10, 30, mc.ToString());
        //        Font.renderString(10, 40, "HELLO WORLD\nTHIS IS ZARLO");
        //      if (mouse.isLeftClicked())
        //      {
        //          Font.renderString(10, 60, "LEFT BUTTON DOWN");
        //        }
        //      if (mouse.isRightClicked())
        //      {
        //          Font.renderString(10, 60, "RIGHT BUTTON DOWN");
        //        }

        //        Font.renderString(60, 10, "MAX RAM:" + PunkOS.HAL.CPU.GetMemory().ToString());
        //      Font.renderString(60, 20, "USED RAM:" + PunkOS.HAL.CPU.GetUsedMemoryByKernel().ToString());



        //          _Picture.renderPicture(10, 70, "logo");
        //          _Picture.renderPicture(30, 70, "boo");

        //  mr.renderMouse();
        //          screen.step();
      }
    }
    }
}
