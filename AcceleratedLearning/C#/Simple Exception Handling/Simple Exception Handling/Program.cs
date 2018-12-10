using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                decimal antal = 24M;
                Console.WriteLine("The Chocolate contains 24 pieces");
                Console.Write("How many wants to share? ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                decimal share = decimal.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                decimal resultat = antal / share;

                if (share < 0)
                {
                    throw new Exception();
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nEveryone gets " + resultat + " pieces. \n");
                Console.ForegroundColor = ConsoleColor.White;


            }
            catch (FormatException ex)

            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("That can't be right dude, are you sure u entered a number?");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;


            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("That can't be right, who doesn't like chocolate?");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Negative values is for cowards!");
                Console.WriteLine($"Error Message: {ex.Message}");
                Console.ForegroundColor = ConsoleColor.White;

            }



        }
    }
}
