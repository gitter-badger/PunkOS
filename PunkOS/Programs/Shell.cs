using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = PunkOS.System;

namespace Programs
{
    class Shell
    {
        public static void Run(string path)
        {
            string Script = Sys.IO.File.ReadAllText(path);
            
        }

    }
}
