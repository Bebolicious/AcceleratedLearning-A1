using System;

namespace nenotestarmetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input;
            input = Userinput();
            Skrivut(input);

        }

        private static string Userinput()
        {
            Console.WriteLine("Ange ett namn");
            string name = Console.ReadLine();
            return name;
        }

        private static void Skrivut(string input)
        {
            Console.WriteLine(input);
          
        }
    }
}
