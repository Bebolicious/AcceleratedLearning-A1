using System;

namespace checkpoint01
{
    class Program
    {
        static void Main()
        {
            int num, i, j, k;
            Console.Write("Ange nummer: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                for (j = 1; j < num - i + 1; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("#");
                    Console.Write("");
                }
                Console.WriteLine();

            }


        }
        
    }
}


