using System;

namespace ifstatements
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

                        string vakna;
                        string sova;
                        int resultat1;
                        int resultat2;
                        int dygn = 24;


                        Console.WriteLine("When did you go to bed?");
                        sova = Console.ReadLine();
                        Console.WriteLine("When did u wake up?");
                        vakna = Console.ReadLine();

                        resultat1 = int.Parse(sova);
                        resultat2 = int.Parse(vakna);

                        var antaltimmar = dygn % resultat1 + resultat2;

                        if (antaltimmar ==8 || antaltimmar ==9)
                        {
                            Console.WriteLine($"You have slept {antaltimmar} hours, Thats a good ammount of sleep");
                        }
                        else if (antaltimmar < 8)

                        {
                            Console.WriteLine($"You have slept {antaltimmar} hours, You should sleep some more");

                        }
                        else if (antaltimmar >=10 )

                        {
                            Console.WriteLine($"You have slept {antaltimmar} hours, thats a bit too much");
                        }
                        */





            Loopen();





        }

        static void Loopen()

        {
            string name;
            int valu = 0;
            var run = true;
            bool jiffy = true;
            string yes;

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine("How many times?");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want your name on separete lines? (yes or no)");
            yes = Console.ReadLine();
            if (yes == "no")
            {
                jiffy = false;
            }


            while (run == true)
            {

                if (jiffy == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine($"\r{name}");
                    valu++;
                }
            }

                else if (jiffy == false)
                
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine($"\r{name}");
                    valu++;
                

                if (valu >= antal)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    run = false;

                    Console.WriteLine("\n\nDär tog det stopp \n\n\n\n\n");
                }

                
                



                    /*while (valu < antal)
                    {

                        Console.WriteLine(name);
                        valu++;

                    }*/



                }

            }



          

            
        }
    }
}
