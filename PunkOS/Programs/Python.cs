using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;


namespace PunkOS.Programs
{
    public class Python
    {

        public static void Command(List<string> args)
        {
            PythonEngine.Initialize();


        }

    } 
}
