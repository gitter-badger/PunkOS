using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Python.Runtime;
using AluminumLua;

using CGF.System;


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

           

            myVFS = new CosmosVFS();
            VFSManager.RegisterVFS(myVFS);

            Commands.Init();

           
            //PythonEngine.Initialize();

            

            //var context = new LuaContext();
            //context.SetGlobal("OSv", OSv);
            //context.SetGlobal(,);
            //context.AddBasicLibrary();
            //context.AddIoLibrary();

            // ...

            //var Lparser = new LuaParser(context,@"0:/Core/lua/main.lua"); // < or leave file_name out to read stdin
            //Lparser.Parse();

            Console.Clear();

            


        }

        protected override void Run()
        {

            
            
        }
    }
}
