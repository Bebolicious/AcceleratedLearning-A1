using System.Collections.Generic;
using System.Linq;
using System;

namespace MethodsAndLists.Core
{
    public class NumberListToString
    {
        // Demo: returnera "fjärde talet är jättestort" om det är större än 10000

        public string ReportNumberOfNegativeValues(List<int> numbers)
        {
            int Counter = 0;
            foreach (var number in numbers)
            {
                if (number < 0)
                    Counter++;
            }

            if (Counter == 0)
                return "Jippi! Det finns inga negativa tal i listan";
            else if (Counter == 1)
                return "Det finns ett negativt tal i listan";
            else
                return "Det finns " + Counter + " st negativa tal i listan";
        }

        public string ReportIfAllValuesAreHigherThan100(List<int> numbers)
        {
            //string hej = numbers.Where(item => item > 100).ToString();

            string ut = "";


            foreach (var item in numbers)
            {
                if (item > 100)
                {
                    ut = "Alla nummer är högre än 100";
                }
                else if (item <= 100)
                {
                    ut = "Något nummer är lägre än (eller lika med) 100";
                    break;
                }

            }
            return ut;
        }

        public string ReportFirstAndLastValue(List<int> nummerlista)
        {
            //int first = numbers[0];
            //int index = numbers.Count - 1;
            //int last = numbers[index];



            //return $"Första siffran är {first} och sista siffran är {last}";

            return "Första siffran är " + nummerlista.First() + " och sista siffran är " + nummerlista.Last();
        }

        public string ReportFirstAndLastValue_Linq(List<int> numbers)
        {
            throw new Exception();
        }
    }
}