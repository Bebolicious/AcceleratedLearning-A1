using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Importing_info_from_files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Show> allShows = GetShowsFromTextFile();

            DisplayInfoAboutShows(allShows);

            Console.ReadKey();
        }

        public static void DisplayInfoAboutShows(List<Show> AllShows)
        {
            Console.WriteLine("ALLA TITLAR:\n");
            foreach (var item in AllShows)
            {
                Console.WriteLine($"{item.Showname}");
            }
            Console.WriteLine();

            Console.WriteLine("PROGRAM SOM BÖRJAR SENARE ÄN KL 21: \n");

            foreach (var item in AllShows)
            {
                if (item.Startat.Hours > 20)
                {
                    Console.WriteLine($"{item.Channel} {item.Startat} {item.Showname}");
                }
                    
            }
            Console.WriteLine("\nPROGRAM FRÅN SVT2 I KRONOLOGISK ORDNING: ");

            foreach (var show in AllShows.Where(x => x.Channel == "SVT2").OrderBy(x => x.Startat))
            {
                Console.WriteLine(show);
            }





        }

        

        public static List<Show> GetShowsFromTextFile()
        {



            var shows = new List<Show>();
            string[] readlines = File.ReadAllLines("c:\\Temp/tvdata.txt");

            foreach (var item in readlines)
            {
                string kanal = item.Split('*')[0];
                string tid = item.Split('*')[1];
                string namn = item.Split('*')[2];

                TimeSpan tid2 = TimeSpan.Parse(tid);
                
                var klar = new Show
                {
                    Showname = namn,
                    Startat = tid2,
                    Channel = kanal
                };
                shows.Add(klar);
            }
            return shows;
        }
    }
}
               
