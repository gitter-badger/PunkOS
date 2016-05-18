using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpOS;
using System.IO;

namespace SharpOS.Apps
{
    class nullapp : IApplication
    {

        bool r = false;

        public override bool Running
        {
            get
            {
                return r;
            }

            set
            {
                r = value;
            }
        }

        public override void End()
        {
            throw new NotImplementedException();
        }

        public override void MainLoop()
        {
            
        }

        public override void Start(string[] args)
        {
            Console.WriteLine("SharpOS not Found" + args);
        }
    }
}