using System;
using System.Collections.Generic;

namespace PunkOS
{
    static class Commands
    {
        static commandBase[] commands = new commandBase[256];
        static int icommand = 0;
        public static void Init()
        {
            add(new commandBase("lua", new commandBase.command(Programs.Lua.Command)));
            commands[0].sethelp("runs lua script");
            add(new commandBase("shell", new commandBase.command(Programs.Shell.command)));
            commands[1].sethelp("Runs Things");
            add(new commandBase("echo", new commandBase.command(Commands_command.echo)));
            commands[2].sethelp("echo's back");
            add(new commandBase("help", new commandBase.command(help)));
            commands[3].sethelp("prints help info");
            add(new commandBase("sharpapps", new commandBase.command(PunkOS.Programs.SharpOSApps.command)));
            commands[4].sethelp("lets you runn sharpos apps (not working)");
            //add(new commandBase("edit", new commandBase.command(Commands_command.edit)));
            //commands[].sethelp("Edit Files");
        }
        // school work
        // tonality
        // the scale used to write the song
        // major/minor/other
        //
        //
        //
        //


        /// <summary>
        /// lest you set the help info of a program
        /// </summary>
        /// <param name="program">name fo program</param>
        /// <param name="helpinfo">the help info</param>
        public static void sethelp(string program,string helpinfo)
        {

            getCommand(program).sethelp(helpinfo);
        }

        public static void add(commandBase com , string helpinfo)
        {

            commands[icommand] = com;
            commands[icommand].sethelp(helpinfo);
            icommand++;

        }

        public static void add(commandBase com)
        {
            commands[icommand] = com;
            icommand++;
        }
        public static void Parse(string text)
        {
            try
            {
                List<string> tokens = Tokenizer.getTokens(text);

                getCommand(tokens[0]).execute(text);

            }
            catch (Exception exception)
            {

                Console.WriteLine(exception);

            }
        }
        public static commandBase getCommand(string text)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (text.Split(' ')[0].ToLower() == commands[i].text)
                {
                    return commands[i];
                }
            }
            return new commandBase("null", new commandBase.command(Commands_command.nothing));
        }
        public static string getCommandHelp(string text)
        {
            for (int i = 0; i < commands.Length; i++)
            {
                if (text.Split(' ')[0].ToLower() == commands[i].text)
                {
                    return commands[i].gethelp();
                }
            }
            return "Command not found";
        }


        public static void help(List<string> args)
        {

            if (args[1] == null)
            {

                for (int i = 0; i < commands.Length; i++)
                {
                    Console.WriteLine(commands[i].gethelp());
                }

            }

        }

    }
    class commandBase
    {
        string _help = "";
        public commandBase(string _text, command _command)
        {
            executec = _command;
            text = _text;
        }
        public void execute(string s)
        {
            executec(Tokenizer.getTokens(s));
        }
        public string gethelp()
        {
            return _help;
        }
        public void sethelp(string help)
        {
            _help = help;
        }
        public command executec;
        public string text;
        public delegate void command(List<string> args);
    }
    class Tokenizer
    {
        public const char split = ' ';
        public const char quote = '"';
        public static List<string> getTokens(string s)
        {
            bool isinquotes = false;
            List<string> tokens = new List<string> { "" };
            string temp = "";
            foreach (char c in s)
            {
                temp = tokens[tokens.Count - 1];
                if (c == quote) { isinquotes = !isinquotes; }
                else if (c == split && isinquotes == false) { tokens.Add(""); }
                else { tokens[tokens.Count - 1] += c; }
            }
            return tokens;
        }
    }
    class Commands_command
    {


        public static void echo(List<string> args)
        {
            int i = 1;
            while (args[i] != null)
            {

                Console.WriteLine(args[i].Replace("/n ", Environment.NewLine));
                i++;

            }
            //Console.WriteLine("");
        }

        public static void nothing(List<string> args)
        {

            Console.WriteLine("Command " + args[0] + " not found.");

        }

    }

}
