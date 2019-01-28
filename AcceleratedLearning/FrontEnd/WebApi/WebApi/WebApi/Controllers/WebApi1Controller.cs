using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("WebApi1")]
    public class WebApi1Controller : Controller
    {

        [Route("AddPlanet")]
        public IActionResult AddPlanet()
        {
            string formContent = "";
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                formContent = reader.ReadToEndAsync().Result;
            }

            // Du behöver göra "Planet"-klassen och metoden "ParsePlanet"
            Planet planet = ParsePlanet(formContent);

            return Ok($"Your planets name: {planet.Name}. Your planets size: {planet.Size}m2");
        }



        [Route("ParsePlanet")]
        private Planet ParsePlanet(string formContent)
        {
            Planet planet = new Planet();

            string[] planets = formContent.Split('&');

            var Name = planets[0].Substring(planets[0].IndexOf('=') + 1);
            var Size = planets[1].Substring(planets[1].IndexOf('=') + 1);

            planet.Name = Name;
            planet.Size = int.Parse(Size);


            return planet;
        }

        [HttpPost("AddPlanet2")]
        public IActionResult AddPlanet2(Planet planet)
        {

            return Ok($"You have added the planet {planet.Name} with the size of {planet.Size}");
        }

        [HttpGet("Searchplanet")]
        public IActionResult Search(Planet planet)
        {

            return Ok($"Searching for planets with the name '{planet.Name}' and the size '{planet.Size}'");
        }


        [HttpGet("Hello")]
        public string Hello()
        {
            return "Hello";
        }

        [HttpGet("HelloWorld")]
        public IActionResult HelloWorld()
        {

            Random rndm = new Random();
            int phrase = rndm.Next(1, 4);

            if (phrase == 1)
            {
                return Ok("Hello World");
            }
            else if (phrase == 2)
            {
                return Ok("Bonjour le monde");

            }
            else
            {
                return Ok("Hei maailma");
            }



        }
        [HttpGet("Weekday")]
        public IActionResult Weekday()
        {
            DateTime today = DateTime.Now;
                return Ok($"Today is {today.DayOfWeek} the {today.Day}/{today.Month}");
        }

        [HttpGet("Cliche")]
        public IActionResult Cliche()
        {
           DayOfWeek weekday = DateTime.Now.DayOfWeek;

            switch (weekday)
            {
                
                case DayOfWeek.Monday:
                    return Ok("Funday Monday!");
                case DayOfWeek.Tuesday:
                    return Ok("UP & AT EM !");
                case DayOfWeek.Wednesday:
                    return Ok("It's little Saturday!");
                case DayOfWeek.Thursday:
                    return Ok("I don't have a quote for today, I'm sorry!");
                case DayOfWeek.Friday:
                    return Ok("Friday may be a single day, but without it, the week wouldn't be a week.");
                case DayOfWeek.Saturday:
                    return Ok("Candyday!");
                case DayOfWeek.Sunday:
                    return Ok("Anxiety day!");
               
               
               
            }
            return null;

        }


        //[Route("Addbreakfast")]
        //public IActionResult Addbreakfast()
        //{
        //    string formContent = "";
        //    using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
        //    {
        //        formContent = reader.ReadToEndAsync().Result;
        //    }

        //    // Du behöver göra "Planet"-klassen och metoden "ParsePlanet"
        //    Breakfast breakfast = Breakfast(formContent);

        //    return Ok($"Your planets name: Your planets size: m2");
        //}

        //private Breakfast Breakfast(string formContent)
        //{

        //    Breakfast eat = new Breakfast()


        //}


        [HttpPost("Addbreakfast")]
        public IActionResult Addbreakfast(Breakfast breakfast)
        {

            return Ok($"{breakfast.Type} is sooo good!");
        }
    }
}
