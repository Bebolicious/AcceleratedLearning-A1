using System;
using System.Collections.Generic;
using MethodsAndLists.Core.Models;

namespace MethodsAndLists.Core
{
    public class StringToObjectList
    {
        public List<City> ParseCities(string input)
        {
            
                
            if (input == null)
                throw new ArgumentException();
            // Vi Skapar en lista i classen City där vårt resultat hamnar"
            var lista = new List<City>();
            // Vi skapar en string array från den långa strängen vi får från input (så att vi kan splitta namn+population)
            string[] array1 = input.Split(';');

            if (input.Trim() == "")
                return lista;


            /* Vi gör en foreach loop för att kunna splitta vår redan splittade sträng yttligare, denna gången lägger 
             vi in det i en array där resultaten efter split från ; ser ut ungefär såhär:
                                                                                         Göteborg,401956
                                                                                         Lomma,13016               */

            // v vi tar in värdet från vår array fylld med splittade städer+population
            foreach (var namn_och_population in array1)
            {
                // Nu splittar vi våra värden i en ny array. Denna gången separerar vi namn och population (",")
                string[] array2 = namn_och_population.Split(',');

                /* Vi skapar ett ny City och lägger till i vår lista. här tar constructorn i "City.cs" in att allt i 
                 * första position i arrayen och lägger till namn och sedan vice versa med andra positon (Population) */

                lista.Add(new City() {Name = array2[0], Population = int.Parse(array2[1]) });


            }

                // Till sist skickar vi tillbaka den kompletta listan till metoden (iom. att den ber om en lista)
            return lista;
        }
    }
}
