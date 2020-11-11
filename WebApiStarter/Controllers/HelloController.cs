using Microsoft.AspNetCore.Mvc;

namespace WebApiStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
