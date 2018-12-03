using System;
using System.Collections.Generic;

namespace array
{
    class Program
    {
        static void Main()
        {
            List<string> namnlista = new List<string>();
            Console.WriteLine("Ange namn: (När du är klar skriver du 'klar'");

            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();



               

                if (input == "klar")
                {
                    foreach (var item in namnlista)
                    {
                        Console.WriteLine(item);
                    }
                    
                }
                namnlista.Add(input);
                i++;


            }

           

        }
    }
}
