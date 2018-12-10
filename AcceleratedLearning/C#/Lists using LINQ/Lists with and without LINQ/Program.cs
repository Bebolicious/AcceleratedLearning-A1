using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_with_and_without_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            

            List<int> numberlist = Createlist();

            List<int> numberHigherThan = NumberHigherThan(numberlist);

            List<string> starslist = Starify(numberlist);


            Console.WriteLine($"numberHigherThanFive = {string.Join(",", numberHigherThan)}");
            Console.WriteLine($"starslist = {string.Join(",", starslist)}");
           

        }

        private static List<int> NumberHigherThan(List<int> randomnamnhehehehe)
        {
            var result = new List<int>();
            foreach (var i in randomnamnhehehehe)
            {
                if (i > 50)
                    result.Add(i);
            }
            return result;
        }

        private static List<string> Starify(List<int> numberlist)
        {
            var star = new List<string>();
            foreach (int i in numberlist)
            {
                star.Add($"*{i}*");
            }
            return star;
        }

        private static List<int> Createlist()
        {
            var numbers = new List<int>();
            numbers.Add(25);
            numbers.Add(82);
            numbers.Add(55);
            return numbers;
        }

       
        //private static List<int> Listcalc(List<int> avarage)
        //{
        //    var reslist = new List<int>();
          

        //    foreach (var i in reslist)
        //    {
        //        if (i > 5)
        //            reslist.Add(i);
        //     }
        //    return reslist;
        //}

      
    
       

        
    }
}

