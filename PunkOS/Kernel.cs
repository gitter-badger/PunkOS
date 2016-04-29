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
            
        }

        protected override void Run()
        {


            int i = 0;
            do
            {
                //Console.Write("$>");
                //var input = Console.ReadLine();
                //Console.WriteLine(input);
                //System.Manger.CommandManger.run(input);
                i++;
                Console.WriteLine(i);
            } while (true);


        }
    }
}
