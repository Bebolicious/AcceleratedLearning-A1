using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("WebApi4")]
    public class WebApi4Controller : Controller
    {

        [HttpGet("ShareChocolate")]
        public IActionResult ShareChocolate(int people)
        {

            int totalchoc = 25;


            if (people == 0)
            {
                return BadRequest("Cant be divided by zero!");
            }
            else
            {
                int res = totalchoc / people;
                return Ok(res);
            }

        }

        [HttpGet("GetOrder")]
        public IActionResult GetOrder(string order)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniMaxChars = new Regex(@".{7,7}");
            var hasMaxChars = new Regex(@".{8,8}");


            if (!hasMiniMaxChars.IsMatch(order) || hasMaxChars.IsMatch(order))
            {
                return BadRequest("Wrong Format, Please enter format 'AA-111'");
            }

            string[] check = order.Split('-');

            int ordernum = int.Parse(check[1]);

            if (ordernum > 3000)
            {
                return BadRequest("The order doesnt exist");
            }
            else
            {
                string orderout = check[0].ToString().ToUpper() + "-" + check[1].ToString();
                return Ok($"{orderout}: 400x TV Wallmounts, 150x Powerstrips \n Sum: 49759:-");
            }

        }

        //[HttpGet("GetUser")]
        //public IActionResult GetUser(string user)
        //{

        //    string html = "<img src=\"https://media1.tenor.com/images/b58eab257b239c62a29b7093db9fee95/tenor.gif?itemid=9320567 \"/>";

        //    if (user.ToLower() == "stewie")
        //    {
        //        return BadRequest();
        //    }

        //    else if (user.ToLower() == "peter")
        //    {
        //        return Content($"<img src=\"https://media1.tenor.com/images/b58eab257b239c62a29b7093db9fee95/tenor.gif?itemid=9320567 \"/>");
        //    }
        //    switch (user.ToLower())
        //    {
        //        case "meg":
        //            return Ok(html, "text/html");
        //    }



        //}


    }

}