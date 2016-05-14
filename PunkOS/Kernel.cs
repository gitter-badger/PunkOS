using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using sys = System.IO;
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
            myVFS.Initialize();
            UserSystem.Init();

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

            
            //Commands.Parse("shell 0:\test.txt");
            Console.Clear();
            Console.WriteLine("PunkOS 0.0.1");
            Console.Write("$>");
        }

        protected override void Run()
        {
            string input = Console.ReadLine();
            string inputtemp = input;
            if (inputtemp.Replace(" ","") != "")
            {
                Commands.Parse(input);
            }
            Console.Write("$>");
        }
    }
}
