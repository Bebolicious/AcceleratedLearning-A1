using System;
using System.Collections.Generic;

namespace Liste_and_manipulation_of_ints
{
    class Program
    {
        static void Main(string[] args)
        {
            /* NOTE THIS APPLICATION IS NOT FINISHED
             * NOTE THIS APPLICATION IS NOT FINISHED
             * NOTE THIS APPLICATION IS NOT FINISHED
             * NOTE THIS APPLICATION IS NOT FINISHED
             * TODO - Take in ints in a list and make a total and median out of them*/




            List<int> number = new List<int>();

            do
            {

            
                Console.Write("Enter a name: ");
                int input = int.Parse(Console.ReadLine());     
                number.Add(input);
            }
            while (int.Parse="quit");
            { 
            Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine();
                number.Sort();

            }
           
            foreach (int resultat in number)
            {
                Console.WriteLine(resultat);
            }


        }
    }
}
