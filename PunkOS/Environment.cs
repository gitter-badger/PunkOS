using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS
{
    public class Environment_var
    {
        public static string[] key = new string[100];
        public static string[] value = new string[100];
        static int i = 0;
        public static void Init()
        {
            load();


        }

        public static void save()
        {

        }

        public static void load()
        {
            i = 0;
           
        }

        public static void add(string _key, string _value)
        {

            key[i] = _key;
            value[i] = _value;

            i++;
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
