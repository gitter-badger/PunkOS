using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Python.Runtime;
using AluminumLua;


namespace PunkOS
{
    public class Kernel : Sys.Kernel
    {
        readonly string OSv = "0.0.2.0";
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
            Console.WriteLine("loading Python");

            //PythonEngine.Initialize();

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("   ########   ");
            Console.WriteLine("Loading Lua5.2");

            var context = new LuaContext();
            context.SetGlobal("OSv", OSv);
            //context.SetGlobal(,);
            context.AddBasicLibrary();
            context.AddIoLibrary();

            // ...

            //var Lparser = new LuaParser(context,@"0:/Core/lua/main.lua"); // < or leave file_name out to read stdin
            //Lparser.Parse();


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


            Console.WriteLine("PunkOS 0.0.2.1");
            //Console.WriteLine(line);
            Console.WriteLine("By Kaleb Mcghie");
            Console.Write("$>");
        }

        protected override void Run()
        {

            Commands.Parse(Console.ReadLine());
            Console.Write("$>");
        }
    }
}
