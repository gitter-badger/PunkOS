using System;
using System.Collections.Generic;

using AluminumLua;

namespace PunkOS.Programs
{
   public class Lua
    {


        public static void Command(List<string> args)
        {
            Console.WriteLine("Lua Is Not Working It need Some Plugs");
            if (args[1].Contains("0:/"))
            {

                //var parser = new LuaParser(programing_languages.context, args[1]);
                
                //parser.Parse();

            }
            if(args[1] == "help")
            {

                Console.WriteLine("AluminumLua 0.1 (c) 2011 Alex Corrado modded by zarlo cooman to work with PunkOS");

            }else
            {

            }


        }

    }
}
