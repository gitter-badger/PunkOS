using Sys = System.IO;

namespace PunkOS.System.IO
{
    class Path
    {

        public string GetUserPath()
        {
            return  @"0:/user/" + LoginSystem.user() + "/";
        }

        public string GetTempPath()
        {
            return @"0:/Temp/" + LoginSystem.user() + "/";
        }

    }
}
