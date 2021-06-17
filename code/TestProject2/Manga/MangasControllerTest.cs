using Manga.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace TestProject2
{
   public class MangasControllerTest
    {
         [Fact]
         public void GetTest()
         {
            //arrange

            MangasController mangasController = new MangasController();
            var mangasControllerResult = mangasController.Get();

            // Action

            Assert.IsType<ActionResult<string>>(mangasControllerResult);

            //Assert
            Assert.NotNull(mangasControllerResult);

         }

        

    }
}
