using System;

namespace newnew4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = GetInputFromUser();

            string[] peopleArray = CreateArrayOfPeople(response);

            RespondToUser(peopleArray);
        }

        private static string GetInputFromUser()
        {
            Console.Write("Enter a list of names (separate with ','): ");
            string answer = Console.ReadLine();

            return answer;
        }

        private static string[] CreateArrayOfPeople(string response)
        {
            if (string.IsNullOrWhiteSpace(response))
                return new string[] { };

            string[] list = response.Split(',');

            return list;
        }

        private static void RespondToUser(string[] peopleArray)
        {
            if (peopleArray.Length == 0)
            {
                Console.WriteLine("No people in the list");
                return;
            }

            foreach (string person in peopleArray)
            {
                Console.WriteLine($"***SUPER-{person.ToUpper()}***");
            }
        }
    }
    }
