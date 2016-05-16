using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpOS
{
    class Kernel
    {
        public void StartApplicationLoop(IApplication app, string[] args)
        {
            app.Start(args);
            while (app.Running)
            {
                app.MainLoop(); //while app is running, loop this method.
            }
            app.End(); //stop application, returning control to the kernel.
        }

    }
}
