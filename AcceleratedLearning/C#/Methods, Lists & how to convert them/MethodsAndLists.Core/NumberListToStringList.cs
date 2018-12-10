using System.Collections.Generic;

namespace MethodsAndLists.Core
{
    public class NumberListToStringList
    {

        public List<string> LongOrShort(List<int> heightList)
        {
            var result = new List<string>();
            foreach (var height in heightList)
            {
                string newString;

                if (height < 0 || height > 220)
                    continue;

                if (height < 160)
                    newString = height + "cm är kort";
                else
                    newString = height + "cm är långt";

                result.Add(newString);
            }

            return result;
        }

        public List<string> NegativeNumbersIsZip_PositiveNumbersIsZap_ZeroIsBoing(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString;

                if (number == 0)
                {
                    newString = "BOING";
                }
                else if (number < 0)
                {
                    newString = "ZIP";
                }
                else
                {
                    newString = "ZAP";
                }

                result.Add(newString);
            }

            return result;
        }

        public List<string> AddStarsToNumbersHigherThan1000(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString = number.ToString();
                if (number > 1000)
                {
                    newString = "***" + number + "***";
                }

                result.Add(newString);
            }

            return result;
        }

        public List<string> AddStars(List<int> numbers)
        {
            var result = new List<string>();
            foreach (var number in numbers)
            {
                string newString = "***" + number + "***";
                result.Add(newString);
            }

            return result;
        }
    }
}