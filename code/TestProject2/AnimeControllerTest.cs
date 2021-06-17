using Microsoft.AspNetCore.Mvc;
using Anime.Controllers;
using System;
using Xunit;

namespace TestProject2
{
    public class AnimeControllerTest
    {

        
        [Fact]
        public void GetTest()
        {

            //arrange 
            AnimesController animesController = new AnimesController();
            var animesControllerResult = animesController.Get();

            //Action
            Assert.IsType<ActionResult<string>>(animesControllerResult);

            //Assert
            Assert.NotNull(animesControllerResult);

        }
    }
}
