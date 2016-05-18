using SharpOS.SystemRing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpOS
{
    public class Kernel
    {
        // this dose not get used
        public void StartApplicationLoop(IApplication app, string[] args)
        {
            app.Start(args);
            while (app.Running)
            {
                app.MainLoop(); //while app is running, loop this method.
            }
            app.End(); //stop application, returning control to the kernel.
        }

        public void MessageBox(string title, string text)
        {
            List<string> message_lines = new List<string>();
            message_lines.Add("+------[ " + title + " ]------+");
            string t = message_lines[0];
            int h_space = t.Length - 2;
            message_lines.Add("|" + Repeat(" ", h_space) + "|");
            int h_pad = h_space - 2;
            foreach (string c in SplitChunks(text, h_pad))
            {
                message_lines.Add("| " + c + Repeat(" ", c.Length - h_pad) + " |");
            }
            message_lines.Add("|" + Repeat(" ", h_space) + "|");
            string button = "[enter:ok] ";
            int blength = button.Length;
            int bpad = (h_space - blength) - 1;
            message_lines.Add("|" + Repeat(" ", bpad) + button + " |");
            message_lines.Add("+" + Repeat("-", h_space) + "+");
            DrawCenter(message_lines.ToArray());
            var k = Keyboard.ReadKey();
            if (k.Key == "enter")
            {
                Console.CursorLeft = 0;
                Console.CursorTop = 0;
                Console.Clear();
            }
        }

        public void DrawCenter(string[] contents)
        {
            int cornerx = (Console.WindowWidth - contents[0].Length) / 2;
            int cornery = (Console.WindowHeight - contents.Length) / 2;
            for (int i = 0; i < contents.Length; i++)
            {
                Console.CursorLeft = cornerx;
                Console.CursorTop = cornery + i;
                Console.Write(contents[i]);
            }


        }

        public string Repeat(string text, int length)
        {
            string t = text;
            while (text.Length <= length)
            {
                text += t;
            }
            return text;
        }

        public string[] SplitChunks(string orig, int size)
        {
            if (string.IsNullOrEmpty(orig))
            {
                throw new ArgumentNullException("orig");
            }

            if (size <= 0)
            {
                throw new ArgumentException("Size of chunk must be above 0.");
            }

            List<string> chunks = new List<string>();
            while (orig.Length >= size)
            {
                chunks.Add(orig.Substring(0, size));
                orig = orig.Remove(0, size);
            }
            if (orig.Length > 0)
            {
                chunks.Add(orig);
            }
            return chunks.ToArray();
        }

    }
}
