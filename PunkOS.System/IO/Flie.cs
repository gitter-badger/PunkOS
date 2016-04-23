using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = System.IO;
using g = System;

namespace PunkOS.System.IO
{
    class File
    {
        
        public string ReadAllText(string FilePath)
        {
            return Sys.File.ReadAllText(FilePath);
        }

        public Byte[] ReadAllBytes(string FilePath)
        {
            return Sys.File.ReadAllBytes(FilePath);
        }

        public string[] ReadAllLines(string FilePath)
        {
            return Sys.File.ReadAllLines(FilePath);
        }

        public Boolean WriteAllText(string FilePath,string data)
        {
            Sys.File.WriteAllText(FilePath,data);
            return true;
        }

        public Boolean WriteAllLines(string FilePath,string[] data)
        {
            Sys.File.WriteAllLines(FilePath,data);
            return true;
        }

        public Boolean WriteAllBytes(string FilePath,Byte[] data)
        {
            Sys.File.WriteAllBytes(FilePath,data);
            return true;
        }

        public Boolean AppendText(string FilePath,string data)
        {
            Sys.File.AppendAllText(FilePath,data);
            return true;
        }

        public Boolean AppendAllLine(string FilePath,IEnumerable<string> data)
        {
            Sys.File.AppendAllLines(FilePath, data);
            return true;
        }

        public Boolean Exists(string FilePath)
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

        public Boolean Delete(string FilePath)
        {
            Sys.File.Delete(FilePath);
            return true;
        }
    }
}
