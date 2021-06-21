using Frontend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject2
{
    public class HomeControllerTest
    {
        

        [Fact]
        public async Task GetStringAsyncTest()
        {
           
            //arrange 
            HomeController homeController = new HomeController();
            var homeControllerResult = await homeController.Index();

            //Action
            Assert.IsType<ActionResult<string>>(homeControllerResult);

            //Assert
            Assert.NotNull(homeControllerResult);

        }
    }
}
