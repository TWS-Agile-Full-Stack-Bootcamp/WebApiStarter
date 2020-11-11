using System;
using System.Net;
using System.Threading.Tasks;
using CompanyApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebApiStarter.Dtos;
using Xunit;

namespace WebApiStarterTest.Controllers
{
    public class UserControllerTest
    {
        [Fact]
        public void Should_return_created_and_location_when_create_user()
        {
            //given
            var userController = new UserController();
            User user = new User() { Name = "string" };

            //when
            CreatedResult actionResult = userController.Create(user) as CreatedResult;

            //then
            Assert.Equal(HttpStatusCode.Created, (HttpStatusCode)actionResult.StatusCode);

            Assert.Matches("/users/[\\S]+", actionResult.Location);
        }
    }
}