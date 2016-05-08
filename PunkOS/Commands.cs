using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PunkOS
{
    static class Commands
    {
        static commandBase[] commands = new commandBase[4];
        static int icommand = 0;
        public static void Init()
        {
            add(new commandBase("lua", new commandBase.command(Programs.Lua.Command)));
            commands[0].sethelp("runs lua script");
            add(new commandBase("shell", new commandBase.command(Programs.Shell.command)));
            commands[1].sethelp("Runs Things");
            add(new commandBase("echo",new commandBase.command(Commands_command.echo)));
            commands[2].sethelp("echos back");
        }
        public static void add(commandBase com)
        {
            commands[icommand] = com;
            icommand++;
        }
        public static void Parse(string text)
        {
            bool didfind = false;
            if (text.Replace(" ", "") != "")
            {
                List<string> tokens = Tokenizer.getTokens(text);
                for (int i = 0; i < commands.Length; i++)
                {
                    if (tokens[0].ToLower() == commands[i].text)
                    {
                        commands[i].execute(text);
                        didfind = true;
                        break;
                    }
                }
                if (!didfind)
                {

                    Console.WriteLine("Command not found.");

                }
            }
            else
            {
                Console.WriteLine("Error");
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
            while (args[i] != null) {
                if (args[i] != "/n") {
                    Console.Write(args[i] + " ");
                } else
                {

                    Console.WriteLine();

                }
                    i++;
            }
        }


        public static void nothing(List<string> args)
        {
           

        }

    }

}
