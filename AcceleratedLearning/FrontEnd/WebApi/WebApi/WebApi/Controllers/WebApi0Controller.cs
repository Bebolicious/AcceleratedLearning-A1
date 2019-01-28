using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("webapi0")]
    public class WebApi0Controller : Controller
    {
        [Route("Test")]
        public string Test()
        {

            return "Hi! From: Server.";

        }


        [Route("Test2")]
        public string Test2()
        {

            return "The clock is: " + System.DateTime.Now;

        }

        [Route("Test3")]
        public IActionResult Test3()
        {
            int i = 3;
            int y = 5;
            int tot = i + y;
            return Ok("Total value: " + tot);
            //return BadRequest();
            //NotFound
        }

        [Route("Test4")]
        public IActionResult Test4()
        {
            int i = 3;
            int y = 5;
            int tot = i + y;
            return Ok("Total value: " + tot);
            //return BadRequest();
            //NotFound
        }


    }
}
