using System;

namespace Enums
{
    class Program
    {
       

        public class Person

        {

            public Gender Genders { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime Birthday { get; set; }
            public Sport Favesports { get; set; }

        }


        public enum Sport
        {
            Tennis, Rugby, Soccer, Hurling, Squash
        }

        public enum Gender
        {
            Male, Female, Other
        }


        static void Main(string[] args)
        {

            Person lisa = new Person
            {
                Name = "Lisa",
                Surname = "Smith",
                Birthday = new DateTime(1980, 1, 2),
                Favesports = Sport.Tennis,
                Genders = Gender.Female

            };

            Console.WriteLine($"Lisa is {lisa.Genders.ToString().ToLower()}");
            Console.WriteLine($"Lisa likes to play {lisa.Favesports.ToString().ToLower()}");
            

            Console.WriteLine($"Lisa is {lisa.Birthday} Years old");

            Console.WriteLine("Here is a list of all enums in sports: \n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (string item in Enum.GetNames(typeof(Sport)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(  );
            Console.WriteLine("Enter a sport:");
            string entersport = Console.ReadLine();

            if (Enum.TryParse(entersport, true, out Sport sport))
            {
                Console.WriteLine($"Oh i love {entersport}");
            }
            else
            {
                Console.WriteLine($"I never heard of {entersport}");
            }
        }
    }
}
