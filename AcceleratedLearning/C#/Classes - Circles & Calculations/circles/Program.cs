using System;

namespace circles
{
    class Program
    {

        class Circle
        {

            //string name;
            //int radius;

            //public void Setradius(string xxx)
            //{

            //    name = xxx;
            //}

            //public string Setname()
            //{

            //    return name;
            //}

            //public void Setradius(int w)
            //{
            //    radius = w;

            //}

            //public int Getradius()
            //{
            //    return radius;
            //}

            //public Circle(string i, int v)
            //{
            //    radius = v;
            //    name = i;

            //}

            //public Sayhello()

            public string sethello;
            public string setarea;

            public string Name { get; set; }
            public double Radius { get; set; }

            public void SayHello(string greeting)
            {

                sethello = greeting;
            }

            public string SayHello()
            {

                return sethello;
            }

            public void WriteArea(string area)

            {
                setarea = area;

            }

            public string WriteArea()
            {

                return setarea;
            }

            public Circle(string i, double v)
            {
                Radius = v;
                Name = i;

            }
            


        }


        static void Main(string[] args)
        {
            Circle bob = new Circle("Bob", 8);
            Circle lisa = new Circle("Lisa", 30);

            bob.SayHello("I'm a circle with the name Bob");
            lisa.SayHello("I'm a circle with the name Lisa");

            

            bob.WriteArea($"My name is Bob, i have the area of {bob.Radius}, my diameter is {bob.Radius * bob.Radius * Math.PI} ");
            
            lisa.WriteArea();

            Console.WriteLine(bob.SayHello() + "\n" + lisa.SayHello() + "\n" + bob.WriteArea());
        }


    }
}
