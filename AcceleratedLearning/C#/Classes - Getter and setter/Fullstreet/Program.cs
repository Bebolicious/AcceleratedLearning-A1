using System;
using System.IO;


namespace Fullstreet
{
    class Program
    {

        class Adress
        {
            public string Streetname { get; set; }
            public string Streetnumber { get; set; }

            public string FullStreet
            {
                get
                {
                    return Streetname + Streetnumber;
                }
            }

        }

        static void Main(string[] args)
        {
            var adress = new Adress
            {
                Streetname = "Hemliga Gatan",
                Streetnumber = "  13 B"

            };


            Console.WriteLine(adress.FullStreet);
        }
    }
}
