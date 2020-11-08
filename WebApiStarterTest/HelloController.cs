using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using WebApiStarter.Controllers;
using Xunit;

namespace WebApiStarterTest
{
    public class HelloControllerTest
    {
        [Fact]
        public void Should_return_hello_world_with_default_request()
        {
            //given
            var orderController = new HelloController();

            //when
            ObjectResult actionResult = orderController.Get() as ObjectResult;

            //then
            Assert.Equal(HttpStatusCode.OK, (HttpStatusCode)actionResult.StatusCode);
            Assert.Equal("Hello World", actionResult.Value);
        }
    }
}
