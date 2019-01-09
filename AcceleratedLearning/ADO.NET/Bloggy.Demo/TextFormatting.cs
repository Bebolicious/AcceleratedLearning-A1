using System;
using System.Collections.Generic;
using System.Text;

namespace Bloggy.Demo
{
    public class TextFormatting
    {
       

        internal static void Header(string text)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine(text.ToUpper());
            Console.WriteLine();
        }

        internal static void Write(string text)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(text);
        }

        internal static void WriteLine(string text = "")
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(text);
        }

        internal static void MenuItems(string v)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(v);
        }

        internal static void MenuItems2(string v)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(v);
        }

        internal static void MenuItems3(string v)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(v);
        }
    }
}
