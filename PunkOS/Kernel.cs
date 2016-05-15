using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using sys = System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using AluminumLua;

namespace PunkOS
{
    public class Kernel : Sys.Kernel
    {
        //private PunkOS.System.Utils.DisplayManger Display;
        private VFSBase myVFS;
        private string[] UserData;
        private string OSv = "0.3.2.1";

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

        // lua not working needs plug

        //Error: Exception: System.Exception: Native code encountered, plug required. Please see https://github.com/CosmosOS/Cosmos/wiki/Plugs). System.IRuntimeMethodInfo  System.Delegate.FindMethodHandle().
        //1 > Called from:
        //1 > System.Delegate::System.Reflection.MethodInfo GetMethodImpl()
        //1 > System.Delegate::System.Reflection.MethodInfo get_Method()
        //1 > AluminumLua.LuaObject::System.String ToString()

            //var context = new LuaContext();
            //context.AddBasicLibrary();
            //context.AddIoLibrary();

            //context.SetGlobal("OSv", OSv);
            //context.SetGlobal("random_string", "hello");
            // ...

            //var parser = new LuaParser(context); // < or leave file_name out to read stdin
            //parser.Parse();

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
