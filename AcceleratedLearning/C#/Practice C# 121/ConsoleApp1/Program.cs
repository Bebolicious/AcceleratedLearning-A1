using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = GetNum();
            int b = GetNum();
            int sum = a + b;
            DisplaySum(sum);





        }

        private static void DisplaySum(int sum)
        {
            Console.WriteLine(sum);
        }

        private static int GetNum()
        {
            Console.Write("Enter a number: ");
            int ask = int.Parse(Console.ReadLine());

            return ask;


        }
    }
}
