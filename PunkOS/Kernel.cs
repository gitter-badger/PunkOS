using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;


namespace PunkOS
{
    public class Kernel : Sys.Kernel
    {
        //private PunkOS.System.Utils.DisplayManger Display;
        private VFSBase myVFS;
        private string[] UserData;


        protected override void BeforeRun()
        {

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("              ");
            
            //System.LoginSystem.Init();

            myVFS = new CosmosVFS();
            VFSManager.RegisterVFS(myVFS);

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("      ##      ");

            Commands.Init();

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("    ######    ");



            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("   ########   ");



            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("  ##########  ");



            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("##############");

            Console.Clear();
            //Console.WriteLine("PunkOS Login");
            //Console.WriteLine("Username:");
            //string user = Console.ReadLine();
            //mDebugger.Send(user);
            //Console.WriteLine("Password:");
            //string pass = Console.ReadLine();
            //mDebugger.Send(pass);
            Console.Clear();
            //login code
            Console.WriteLine("PunkOS 0.0.1");
            Console.Write("$>");
        }

        protected override void Run()
        {

                Commands.Parse(Console.ReadLine());
            Console.Write("$>");
        }
    }
}
