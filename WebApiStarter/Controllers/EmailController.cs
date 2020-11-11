using System;
using Microsoft.AspNetCore.Mvc;
using WebApiStarter.Dtos;

namespace WebApiStarter.Controllers
{
    [ApiController]
    [Route("emails")]
    public class EmailController : ControllerBase
    {
        [HttpPost]
        public ActionResult Create(Email email)
        {
            var emailID = new Random().Next();
            return this.Created($"/email/{emailID}", email);
        }
    }
}
