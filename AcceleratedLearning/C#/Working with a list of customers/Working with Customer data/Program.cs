using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Working_with_Customer_data
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allpersons = Getpersoninfo();
            DisplayInfoAboutShows(allpersons);
        }

        private static void DisplayInfoAboutShows(List<Person> allPersons)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Sorted list by age: ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            List<Person> sortbyage = allPersons.OrderBy(item => item.Age).ToList();
            foreach (var item in sortbyage)
            {
                Console.WriteLine($"{item.First}          {item.Age}        {item.Gender}");
            }
        }

        public static List<Person> Getpersoninfo()
        {


            var personer = new List<Person>();
            string[] readlines = File.ReadAllLines("c:\\Temp/userdata.txt");

            foreach (var item in readlines)
            {
                string id = item.Split(',')[0];
                string first = item.Split(',')[1];
                string last = item.Split(',')[2];
                string email = item.Split(',')[3];
                string gender = item.Split(',')[4];
                string age = item.Split(',')[5];

                int id2 = int.Parse(id);
                int age2 = int.Parse(age);

                var klar = new Person
                {
                    ID = id2,
                    First = first,
                    Last = last,
                    Email = email,
                    Gender = gender,
                    Age = age2

                };
                personer.Add(klar);
            }
            return personer;



        }
    }
}
