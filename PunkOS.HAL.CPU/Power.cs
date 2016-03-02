using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.Core
{
   public class Power
    {

        public static void Reboot()
            {
            Cosmos.Core.Global.CPU.Reboot();
            }



    }
}
