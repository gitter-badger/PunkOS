using System;

using System.IO;

using System.Text;

namespace PunkOS
{
    public class Environment_var
    {
        public static string[] key = new string[256];
        public static string[] value = new string[256];
        static int i = 0;
        public static void Init()
        {
            //if (!File.Exists(@"0:\system\env.val"))
            //{
            //    var env_val = File.Create(@"0:\system\env.val");
            //    env_val.Close();
                add("osv", Kernel.OSv);
            //}
            //else
            //{
            //    load();
            //}

        }

        public static void save()
        {

        }

        public static void load()
        {
            i = 0;

            foreach (string line in File.ReadLines(@"0:\system\env.val", Encoding.UTF8))
            {
               string[] temp = line.Split(';');
                add(temp[0],temp[1]);
            }


        }

        public static void add(string _key, string _value)
        {

            key[i] = _key;
            value[i] = _value;

            i++;
        }

        public static void set(string _key , string _value)
        {

            for (int a = 0; a < key.Length; a++)
            {
                if (_key == key[a])
                {
                    value[a] = _value;

                }
            }
            

        }


    public static string get(string _key)
        {
            
            for (int a = 0; a < key.Length; a++)
            {
                if (_key == key[a])
                {
                    return value[a];
                    
                }
            }
            return null;
            
            }

    }

}
