using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkpoint_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string response = GetInputFromUser();

            List<Room> rum = Roomlister(response);
            int counter = 1;

            
            int biggestsize = 0;
            string biggestroom;
            int count2 = 0;

            foreach (var rum2 in rum)
            {


                //for (int i = 0; i < rum2.Size; i++)
                //{
                //    if (rum2.Size > biggestsize)
                //    {
                //        biggestsize = rum2.Size;

                //    }
                //    count2++;
                //}
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Rumsnamn [{counter}]: {rum2.Name}");
                Console.WriteLine();
                counter++;
               
            }
            foreach (var item in rum.OrderByDescending(x=>x.Size))
            {
                Console.WriteLine($"Det största rummet är {item.Name} och det är {item.Size}m2");
                break;
            }







        }

        public static string GetInputFromUser()
        {
            
                Console.WriteLine("Ange namn för rum: ");
            string answer = Console.ReadLine();
             

            return answer;
        }

        public static List<Room> Roomlister(string input)
        {
            var lista = new List<Room>();
            
            string[] roomarray = input.Split("| ");
            

            foreach (string room in roomarray)
            {
                string name = room.Split(' ')[0];
                name = name.Replace("m2", "");

                string kkk = "aaaaa".Substring(0, 2);
                "45m2".Replace("m2", "");

                "43m2".TrimEnd('2').TrimEnd('m');

                int size = int.Parse(room.Split('m')[1]);
                var rum1 = new Room
                {
                    Name = name,
                    Size = size
                    
                };
                lista.Add(rum1);
            }

            return lista;
        }
    }
}
