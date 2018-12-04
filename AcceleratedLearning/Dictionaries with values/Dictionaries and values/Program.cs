using System;
using System.Collections.Generic;

namespace Dictionaries_and_values                                                               //Simple User input Dictionary - AZ
{                                                                                               //User enters an ID and a name.
    class Program                                                                               //ENTER to Summarize the Dictionary
    {
        static void Main(string[] args)
        {
            /* Taking the data of a dictionary from the "BuildProductDictionary */
            Dictionary<int, string> toolsmasterlist = BuildProductDictionary();

            WriteToUser(toolsmasterlist);

        }

        /* (METHOD) Building the Dictionary that we later pass onto the toolsmasterlist Dictionary of the main method */
        private static Dictionary<int, string> BuildProductDictionary()
        {
            // Creating the Dictionary
            var tools = new Dictionary<int, string>();
            tools.Add(1, "Wrench");
            tools.Add(3, "Hammer");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("To use this application input ID followed by a name in this format e.g '4, Shovel' ");
            Console.WriteLine("Press Enter without an input when you're done");
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
        {
                // Asking for input   
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Enter and ID and Tool Name: ");
                
                Console.ForegroundColor = ConsoleColor.Green;
                // Looping while trying to catch exceptions
                // Adding validation
                try
                {

                    string toolname = Console.ReadLine();
                    string[] toollist = toolname.Split(',');

                    if (toolname == "" || toolname == "enter")
                    {
                        break;
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    // Adding user input to a Parsed string[]
                    tools.Add(int.Parse(toollist[0]), toollist[1].Trim());
                }
                catch (IndexOutOfRangeException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid format. ID should be followed by a ',' and a name");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid format. Format Example '4, Shovel'");
                    Console.ForegroundColor = ConsoleColor.White;
                }     
                catch (ArgumentException)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("ID already in use, for educational purpose ID '1' and '3' is preset with tools");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                

                Console.ForegroundColor = ConsoleColor.White;
        }

            // Returning the value of the Dictionary to the main method.
            return tools;
            
        }

        // (METHOD) This method is called last to generate a list of the preset and user inputs of the application
        private static void WriteToUser(Dictionary<int, string> tools)
        {
            Console.WriteLine();
            
            foreach (var item in tools)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"Product ID: {item.Key}, and then name is: {item.Value}");
            }
        }


    }
}


