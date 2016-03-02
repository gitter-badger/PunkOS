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
        private VFSBase myVFS;
        private string[] UserData;
        protected override void BeforeRun()
        {
            
            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("              ");

            mDebugger.Send("Setting up VFS");
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
            Console.WriteLine("PunkOS Login");
            Console.WriteLine("Username:");
            Console.ReadLine();
            Console.WriteLine("Password:");
            Console.ReadLine();
            Console.Clear();
        }

        protected override void Run()
        {

            Console.WriteLine("PunkOS 0.0.1");
            do
            {

                var input = Console.ReadLine();

                System.Manger.CommandManger.run(input);

            } while (true);
            
            
        }
    }
}
