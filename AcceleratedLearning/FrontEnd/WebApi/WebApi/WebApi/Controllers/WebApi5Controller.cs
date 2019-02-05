using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("WebApi5")]
    public class WebApi5Controller : Controller
    {


        [HttpGet("SetPerson")]
        public IActionResult SetPerson(string Name, int Age)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                return BadRequest("Name is a required field.");
            }

            else if (Age < 0 || Age > 120)
            {
                return BadRequest("Age cannot exceed 120 or be less than 0");

            }
            else
            {


            Person person = new Person
            {
                Name = Name,
                Age = Age
            };

            return Ok($"'{person.Name}'with the age of '{person.Age}' will be added to the Db");
            }
        }

        [HttpGet("SetPerson2")]
        public IActionResult SetPerson2(Person person)
        {
        

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {

                return Ok($"'{person.Name}'with the age of '{person.Age}' will be added to the Db");
            }

            }

        }

 
}
