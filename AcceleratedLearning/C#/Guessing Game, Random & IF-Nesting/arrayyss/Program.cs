using System;

namespace arrayyss
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int number = int.Parse(Console.ReadLine());
            string myint = number==20 ? "talet är exakt 20" : number>20 ? "talet är större än 20    " : "talet är mindre än 20";

            Console.WriteLine(myint);*/







            Random rnd = new Random();
            int svar = rnd.Next(1, 100);
            bool stoploop = true;
           
            Console.WriteLine("Gissa ett nummer mellan 1-100");
            while (stoploop == true)
            {


            int gissning = int.Parse(Console.ReadLine());

            if (gissning < svar)
            {
                    if (svar - gissning < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nästan! Din gissning är för låg men max 10 ifrån");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nästan! Din gissning är för låg.");
                    }
            }
                if (gissning > svar)
                {
                    if (svar - gissning < 10)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Nu är du nära! Din gissning var för hög men max 10 ifrån");
                        
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nu är du nära! Din gissning var för hög");
                    }
                }




            if (gissning == svar)
            {
                    stoploop = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n\n\n\n\nDu hade rätt! Svaret är:{svar}\n\n\n\n\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }



            /*int value = int.Parse(Console.ReadLine());
            if (value < 20)
            {
                Console.WriteLine("Ditt värde är mindre än 20");
            }
            else if (value == 20)
            {
                Console.WriteLine("Ditt värde är exakt 20");
            }

            else
            {
                Console.WriteLine("Ditt värde är mer än 20");
            }*/
        }
    }
}
