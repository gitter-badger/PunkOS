﻿using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using sys = System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using AluminumLua;

namespace PunkOS
{
    public class Kernel : Sys.Kernel
    {
        //private PunkOS.System.Utils.DisplayManger Display;
        private VFSBase myVFS;
        private string[] UserData;
        public static string OSv = "0.3.2.1";

        protected override void BeforeRun()
        {

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("              ");
            
            //System.LoginSystem.Init();

            myVFS = new CosmosVFS();
            VFSManager.RegisterVFS(myVFS);
            myVFS.Initialize();
            UserSystem.Init();

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("      ##      ");

            Commands.Init();

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("    ######    ");

            programing_languages.Init();

            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("   ########   ");



            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("  ##########  ");



            Console.Clear();
            Console.WriteLine("Booting PunkOS");
            Console.WriteLine("##############");

            Environment_var.Init();

            Console.Clear();
            
            Console.WriteLine("PunkOS 0.0.1");
            Console.Write("$>");
        }

        protected override void Run()
        {
            string input = Console.ReadLine();
            string inputtemp = input;
            if (inputtemp.Replace(" ","") != "")
            {
                Commands.Parse(input);
            }
            Console.Write("$>");
        }
    }
}
