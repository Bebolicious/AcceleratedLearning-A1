using System;

namespace Cuboids2
{
    class Program
    {
        public class Cube
        {

        
            public double Height;
            public double Width;
            public double Depth;
            


            public Cube(double _Height, double _Width, double _Depth)
            {
                Height = _Height;
                Width = _Width;
                Depth = _Depth;
            }

            //public int Cubeget()
            //{
            //    return v1 + v2 + v3;
            //}

            public double CalculateVolume()
            {

                return (Height * Width * Depth);
            }

            

            //public void WriteVolume()
            //{

            //    Console.WriteLine("The volume of the cube is " + v1 * v2 * v3);



            //}

          


        }


        static void Main(string[] args)
        {
            Cube mycube = new Cube(2, 3, 4);
            Cube supercube = new Cube(100, 200, 300);

            double volume = mycube.CalculateVolume();
            Console.WriteLine($"Volume: {volume}");

            double supervolume = supercube.CalculateVolume();
            
            Console.WriteLine($"Volume: {supervolume}");
        }


    }
}