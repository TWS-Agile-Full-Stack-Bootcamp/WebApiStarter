using System;
using Microsoft.AspNetCore.Mvc;
using WebApiStarter.Dtos;

namespace CompanyApi.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public ActionResult Create(User user)
        {
            return new CreatedResult("/users/1", user);
        }
    }
}
