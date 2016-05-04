using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = PunkOS.System;

namespace PunkOS.Programs
{
    public class Shell
    {
        public static void Run(string path)
        {
            string Script = Sys.IO.File.ReadAllText(path);
            
        }
        public static void command(List<string> args)
        {
            if (args[1].Contains(":/"))
            {
                Run(args[1]);
            } else {

            }

        }

    }
}
