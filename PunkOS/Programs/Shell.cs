using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PunkOS.Programs
{
    public class Shell
    {
        public static void RunATSH(string path)
        {

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Commands.Parse(line);
            }
        }
        public static void command(List<string> args)
        {
            if (args[1].ToLower().EndsWith(".atsh"))
            {
                RunATSH(args[1]);
            } else {

            }

        }

    }
}
