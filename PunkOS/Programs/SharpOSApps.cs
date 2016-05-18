using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS.Programs
{
    public class SharpOSApps
    {
        static SharpOS_Apps[] apps = new SharpOS_Apps[4294967295];
        static int iapp = 0;
        public static void Init()
        {



        }

        public static void add(SharpOS_Apps app)
        {

            apps[iapp] = app;
            iapp++;
        }

        public static void command(List<string> args)
        {
            string[] sharpargs = new string[20];
            int i = 0;
            int ii = 2;
            while (true)
            {
                if (args[i] != null)
                {

                    break;

                }
                sharpargs[i] = args[ii];

            }

            getapp(args[1]).run(sharpargs);

        }

        public static SharpOS_Apps getapp(string text)
        {
            for (int i = 0; i < apps.Length; i++)
            {
                if (text.Split(' ')[0].ToLower() == apps[i].name)
                {
                    return apps[i];
                }
            }
            return new SharpOS_Apps("null",new SharpOS.Apps.nullapp());
        }



    }

    public class SharpOS_Apps
    {
        public SharpOS.IApplication app;
        public string name;
        public SharpOS_Apps(string _name,SharpOS.IApplication _app )
        {
            name = _name;
            app = _app;

        }

        public void run(string[] args)
        {
            app.Start(args);
            while (app.Running)
            {
                app.MainLoop(); //while app is running, loop this method.
            }
            app.End();

        }

    }
}
