using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
namespace PunkOS.HAL
{
    public class time
    {

        public static string Time() { return RTC.Hour + ":" + RTC.Minute + ":" + RTC.Second; }

    }
}
