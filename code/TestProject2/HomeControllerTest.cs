using Frontend;
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

        private AppSettings appSettings = new AppSettings()
        {
            mergeURL = "https://nsama-merge-app.azurewebsites.net"
        };
        [Fact]
        public async void GetFrontendTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            HomeController homeController = new HomeController(options.Object);
            var homeContollerResult = await homeController.Index();

            Assert.NotNull(homeContollerResult);
            //Assert.IsType<OkObjectResult>(homeContollerResult);
        }
    }
}