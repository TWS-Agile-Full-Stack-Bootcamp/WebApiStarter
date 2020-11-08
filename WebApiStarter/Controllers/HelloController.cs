using Microsoft.AspNetCore.Mvc;

namespace WebApiStarter.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [Route("")]
        public string Get()
        {
            return "Hello World";
        }
    }
}
