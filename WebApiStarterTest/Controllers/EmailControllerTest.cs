using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApiStarter.Controllers;
using WebApiStarter.Dtos;
using Xunit;

namespace WebApiStarterTest.Controllers
{
    public class EmailControllerTest
    {
        [Fact]
        public void Should_return_created_and_location_when_create_email_successfully()
        {
            //given
            var emailController = new EmailController();
            var email = new Email() { From = "Tom", To = "Jerry", Subject = "Invitation", Content = "Go for a walk" };

            //when
            ActionResult actionResult = emailController.Create(email);

            //then
            Assert.Equal((int)HttpStatusCode.Created, ((ObjectResult)actionResult).StatusCode);
            Assert.IsType<CreatedResult>(actionResult);
            Assert.Matches("/email/\\S+", ((CreatedResult)actionResult).Location);
        }

        [Fact]
        public void Should_return_bad_request_when_create_email_given_its_to_field_missing()
        {
            //given
            var emailController = new EmailController();
            var email = new Email() { From = "Tom", Subject = "Invitation", Content = "Go for a walk" };

            //when
            ActionResult actionResult = emailController.Create(email);

            //then
            Assert.Equal((int)HttpStatusCode.BadRequest, ((StatusCodeResult)actionResult).StatusCode);
        }
    }
}
