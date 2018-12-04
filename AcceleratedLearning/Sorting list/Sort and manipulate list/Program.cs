using System;
using System.Collections.Generic;

namespace Sort_and_manipulate_list
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Asking for names*/

            
            List<string> names = new List<string>();

            while (true)
            {
                Console.Write("Enter a name: ");
                string input = Console.ReadLine().Trim();
                

                /*Breaks the loop if the user enters "quit"*/
                if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
              
              
                /* Adding input to list*/
                names.Add(input);

            }
            try
            {
                /* Sorting and printing out names*/
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                names.Sort();
                names.RemoveAt(names.Count - 1);
                names.RemoveAt(0);
            }
            catch (Exception)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Error while counting list objects");
                Console.ForegroundColor = ConsoleColor.White;
            }
            foreach (string resultat in names)
            {
                Console.WriteLine("Name: " + resultat);
            }
            

        }
    }
}
