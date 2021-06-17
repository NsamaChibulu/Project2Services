using Merge;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using Merge.Controllers;
using Xunit;

namespace TestProject2
{
    public class MergeControllerTest
    {

        private AppSettings appSettings = new AppSettings()
        {
            animesURL = "https://nsamaanimetest.azurewebsites.net",
            mangasURL = "https://nsamamangatest.azurewebsites.net"
        };
        [Fact]
        public async void GetTest()
        {
            var options = new Mock<IOptions<AppSettings>>();
            options.Setup(x => x.Value).Returns(appSettings);

            MergeController mergeController = new MergeController(options.Object);
            var mergeContollerResult = await mergeController.Get();

            Assert.NotNull(mergeContollerResult);
            Assert.IsType<OkObjectResult>(mergeContollerResult);
        }
    }
}
