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
        public static void Run(string path)
        {
            string[] Script = File.ReadAllLines(path);

            for (int i = 0; Script[i] != null; i++)
            {
                Commands.Parse(Script[i]);
            }

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
