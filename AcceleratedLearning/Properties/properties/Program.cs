using System;

namespace properties
{



    class Program
{
    public class Car
    {
            public string Color { get; set; }
            public int Weight { get; set; }



            public Car(string i, int v)
            {
                Weight = v;
                Color = i;

            }
            public Car()
            {
                Weight = 900;
                Color = "ok färg ändå";
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

            var hej = c1.Color;

        Console.WriteLine("Färgen på bilen 'c1' är " + hej + " och Vikten är " + c1.Weight);
        Console.WriteLine("Färgen på bilen 'c2' är " + c2.Color + " och Vikten är " + c2.Weight);
        Console.WriteLine("Färgen på bilen 'c3' är " + c3.Color + " och Vikten är " + c3.Weight);
    }
}
}



/*string color;
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

        */
