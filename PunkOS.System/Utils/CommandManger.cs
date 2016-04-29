using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.System.Utils
{
  public class CommandManger
  {
        
    public static void run(string CMD) {
            int i = 0;
            
            string output;
            string[] _Command = CMD.Split(' ');
            if (CMD.StartsWith("clear"))
            {

                Console.Clear();
                Console.WriteLine("PunkOS 0.0.1");
            }
            else if (CMD.StartsWith("print"))
            {

                CMD = CMD.Remove(0, 6);

                Console.WriteLine(CMD);

            }
            else if (CMD.StartsWith("help"))
            {

                Console.WriteLine("clear - clear all");
                Console.WriteLine("print - Prints text");

            }
            else if (CMD.StartsWith("run"))
            {
                CMD = CMD.Remove(0,4);
                ProgramManger.runfile(CMD);

            }
            else
            {
                Console.WriteLine("unknown command");
            }
    }

  }
}
