using System;
using System.Collections.Generic;

namespace Gnomes_db
{
    class Program
    {
        
        static void Main(string[] args)
        {


            var dataAccess = new DataAccess();
            List<Gnome> gnomes = dataAccess.GetGnomesFromDatabase();
            DisplayGnomes(gnomes);

        }

        private static void DisplayGnomes(List<Gnome> gnomes)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" " + "Name".PadRight(20) + "Has Beard".PadRight(20) + "Is Evil".PadRight(20) + "Temper".PadRight(20) + "Race");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach (Gnome Gn in gnomes)
            {
                string Line;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("║");
                Console.ForegroundColor = ConsoleColor.White;
                if (Gn.Hasbeard == true)
                {
                    Line = "yes";
                    
                }
                else if (Gn.Hasbeard == false)
                {
                    Line = "No";
                }
                Console.WriteLine(Gn.Name.PadRight(20) + Line.PadRight(20) + Gn.Isevil.ToString().PadRight(20) + Gn.Temper.ToString().PadRight(20) + Gn.Race);
                

            }

            Console.ReadKey();
        }
    }
}
