using System;
using System.Collections.Generic;

namespace Arrays_lists_and_IEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rockstarsArray = new string[] { "Jim Morrison", "Ozzy Osborne", "Van Halen", "James Dio", "Axl Rose", "Steven Tyler" };
            List<string> rockstarsList = new List<string> { "Jim Morrison", "Ozzy Osborne", "Van Halen", "James Dio", "Axl Rose", "Steven Tyler"};

            DisplayArrayOfRockStars("My rockstars: (array)", rockstarsArray);
            DisplayListOfRockStars("My rockstars: (list)", rockstarsList);

            DisplayRockStars("My rockstars: (ienumerable)", rockstarsArray);
            DisplayRockStars("My rockstars: (ienumerable)", rockstarsList);

        }

        public static void DisplayArrayOfRockStars(string[] rockstars)
        {
            foreach (var item in rockstars)
            {
                Console.WriteLine(item);
            }


        }
        
        private static void Printoutrockstars(IEnumerable<string> rockstarsList)
        {
            foreach (var item in rockstarsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
