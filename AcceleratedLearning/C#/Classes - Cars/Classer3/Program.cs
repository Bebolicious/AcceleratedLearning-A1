using System;

namespace Classer3
{
    class Program
    {
        public class Car
        {
            string color;
            int weight;
            public void SetColor(string xxx)
            {

                color = xxx;
            }

            public string GetColor()
            {

                return color;
            }

            public void SetWeight(int w)
            {
                weight = w;

            }

            public int GetWeight()
            {
                return weight;
            }

            public Car(string i, int v)
            {
                weight = v;
                color = i;

            }
            public Car()
            {

            }

        }
        static void Main(string[] args)
        {
            var c1 = new Car("röd", 800);
            var c2 = new Car("blå", 400);
            var c3 = new Car();

            /*c1.SetColor("blå");
            c2.SetColor("röd");
            c1.SetWeight(200);
            c2.SetWeight(300);*/

            /* var yyy = c1.GetColor();
             var zzz = c2.GetColor();
             var qqq = c3.GetColor();*/

            /*int eee = c1.GetWeight();
            int rrr = c2.GetWeight();*/

            var hej = c1.GetColor();

            Console.WriteLine("Färgen på bilen 'c1' är " + hej + " Vikten är " + c1.GetWeight());
            Console.WriteLine("Färgen på bilen 'c2' är " + " Vikten är " );
            Console.WriteLine("Färgen på bilen 'c3' är ");
        }
    }
}
