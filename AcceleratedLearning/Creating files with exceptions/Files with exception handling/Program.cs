using System;
using System.IO;

namespace Creating_files__Exception_and_permission_handling
{
    class Program
    {


        static void Main(string[] args)
        {

            while (true)
            {



                try
                {

                    Console.WriteLine("Enter a file path and file name for your text file: ");
                    File.CreateText(Console.ReadLine());

                  
                    break;



                }

                catch (UnauthorizedAccessException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You don't have access to this folder, ask the computer Admin for assistance.");
                    Console.WriteLine("You don't have access to this folder, ask the computer Admin for assistance.");
                    Console.WriteLine("You don't have access to this folder, ask the computer Admin for assistance.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Try again... \n");


                }


                catch (DirectoryNotFoundException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("The directory you entered does not exist");
                    Console.WriteLine("The directory you entered does not exist");
                    Console.WriteLine("The directory you entered does not exist");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Try again... \n");



                }

                catch (ArgumentException)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You didn't enter anything?");
                    Console.WriteLine("You didn't enter anything?");
                    Console.WriteLine("You didn't enter anything?");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n Try again... \n");


                }





            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your file has been created");
            Console.WriteLine("Your file has been created");
            Console.WriteLine("Your file has been created");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nProgram is shutting down...\n");
            Console.ReadLine();
           

        }
    }
}

