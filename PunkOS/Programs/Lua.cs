﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PunkOS.Programs
{
   public class Lua
    {

        public static void Init()
        {

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

        }

        public static void Command(List<string> args)
        {
            if (args[1] == "")
            {
                //Script.RunFile(args[2]);
            }
            

        }

    }
}
