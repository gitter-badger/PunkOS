using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = System.IO;


namespace PunkOS.System.IO
{
    public class File
    {
        
        public static string ReadAllText(string FilePath)
        {
            return Sys.File.ReadAllText(FilePath);
        }

        public static Byte[] ReadAllBytes(string FilePath)
        {
            return Sys.File.ReadAllBytes(FilePath);
        }

        public static string[] ReadAllLines(string FilePath)
        {
            return Sys.File.ReadAllLines(FilePath);
        }

        public static Boolean WriteAllText(string FilePath,string data)
        {
            Sys.File.WriteAllText(FilePath,data);
            return true;
        }

        public static Boolean WriteAllLines(string FilePath,string[] data)
        {
            Sys.File.WriteAllLines(FilePath,data);
            return true;
        }

        public static Boolean WriteAllBytes(string FilePath,Byte[] data)
        {
            Sys.File.WriteAllBytes(FilePath,data);
            return true;
        }

        public static Boolean AppendText(string FilePath,string data)
        {
            Sys.File.AppendAllText(FilePath,data);
            return true;
        }

        public static Boolean AppendAllLine(string FilePath,IEnumerable<string> data)
        {
            Sys.File.AppendAllLines(FilePath, data);
            return true;
        }

        public static Boolean Exists(string FilePath)
        {
            if (Sys.File.Exists(FilePath))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static Boolean Delete(string FilePath)
        {
            Sys.File.Delete(FilePath);
            return true;
        }
    }
}
