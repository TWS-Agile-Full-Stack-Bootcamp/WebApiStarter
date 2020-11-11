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
            if (email.To == null)
            {
                return this.BadRequest();
            }

            var emailID = new Random().Next();
            return this.Created($"/email/{emailID}", email);
        }
    }
}
