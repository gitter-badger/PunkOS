using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PunkOS.HAL.FileSystem;

namespace PunkOS.System
{
    public class FAT : FATBase
    {
        public string[] ReadFile(string FilePath)
        {
            return ReadText(FilePath);
        }

        public void WriteFile(string FilePath, string[] FileData,string Owner)
        {
            WriteFile(FilePath, FileData);
        }
    }
}
