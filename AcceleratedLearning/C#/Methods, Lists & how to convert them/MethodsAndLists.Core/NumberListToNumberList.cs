using System.Collections.Generic;
using System.Linq;

namespace MethodsAndLists.Core
{
    public class NumberListToNumberList
    {
        // Demo: dubblera alla tal i listan
        // Demo: dubblera alla tal i listan. Hoppa över negativa tal.

        public List<int> Add70ToEverySecondElement(List<int> numbers)
        {
            var result = new List<int>();
            int counter = 1;
            foreach (var number in numbers)
            {
                int newNumber;

                if (counter % 2 == 0)
                    newNumber = number + 70;
                else
                    newNumber = number;

                result.Add(newNumber);

                counter++;
            }

            return result;
        }

        public List<int> Add50ToFirstThreeElements(List<int> numbers)
        {
            var result = new List<int>();
            int numberCounter = 1;
            foreach (var number in numbers)
            {
                int newNumber = number;

                if (numberCounter <= 3)
                    newNumber = number + 50;

                result.Add(newNumber);
                numberCounter++;
            }

            return result;
        }

        public List<int> Add50ToFirstThreeElements_Linq(List<int> numbers)
        {
            var first = numbers.Take(3).Select(n => n + 50);
            var last = numbers.Skip(3);
            return first.Concat(last).ToList();
        }

        public List<int> NegateEachNumber(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = -number;
                result.Add(newNumber);
            }

            return result;
        }

        public List<int> DivideEachNumberBy100(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = number / 100;
                result.Add(newNumber);
            }

            return result;
        }

        public List<int> DivideEachNumberBy100_Linq(List<int> numbers)
        {
            return numbers.Select(x => x / 100).ToList();
        }


        public List<int> GetNumbersDividableByFive(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number % 5 == 0)
                    result.Add(number);
            }

            return result;
        }

        public List<int> GetNumbersDividableByFive_Linq(List<int> numbers)
        {
            return numbers.Where(x=>x%5==0).ToList();
        }

        public List<int> GetNumbersHigherThan1000(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                if (number>1000)
                    result.Add(number);
            }

            return result;
        }


        public List<int> GetNumbersHigherThan1000_Linq(List<int> numbers)
        {
            return numbers.Where(x => x > 1000).ToList();
        }


        public List<int> Add100ToEachNumber(List<int> numbers)
        {
            var result = new List<int>();
            foreach (var number in numbers)
            {
                int newNumber = number + 100;
                result.Add(newNumber);
            }

            return result;
        }

        public List<int> Add100ToEachNumber_Linq(List<int> numbers)
        {
            return numbers.Select(x => x + 100).ToList();
        }


    }
}