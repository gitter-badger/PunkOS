using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluminumLua;

namespace PunkOS
{
    class programing_languages
    {


        //public static LuaContext context = new LuaContext();

        public static void Init()
        {
            // lua not working needs plug
            Lua();

        }


        public static void Lua()
        {

            

            //Error: Exception: System.Exception: Native code encountered, plug required. Please see https://github.com/CosmosOS/Cosmos/wiki/Plugs). System.IRuntimeMethodInfo  System.Delegate.FindMethodHandle().
            //1 > Called from:
            //1 > System.Delegate::System.Reflection.MethodInfo GetMethodImpl()
            //1 > System.Delegate::System.Reflection.MethodInfo get_Method()
            //1 > AluminumLua.LuaObject::System.String ToString()
                        
            //context.AddBasicLibrary();
            //context.AddIoLibrary();
            //context.SetGlobal("OSv", OSv);
            //context.SetGlobal("random_string", "hello");
            
            //var parser = new LuaParser(context); // < or leave file_name out to read stdin
            //parser.Parse();

        }

    }
}
