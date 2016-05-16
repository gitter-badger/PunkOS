using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AluminumLua;

namespace PunkOS.Programs
{
   public class Lua
    {


        public static void Command(List<string> args)
        {
            Console.WriteLine("Lua Is Not Workinf It need Some Plugs");
            if (args[1].Contains("0:/"))
            {

                //var parser = new LuaParser(programing_languages.context, args[1]);
                
                //parser.Parse();

            }
            else
            {

                Console.WriteLine("AluminumLua 0.1 (c) 2011 Alex Corrado modded by zarlo cooman to work with PunkOS");

            }


        }

    }
}
