using Microsoft.AspNetCore.Mvc;

namespace WebApiStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [Route("")]
        public ActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
