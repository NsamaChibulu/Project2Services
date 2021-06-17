using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Anime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimesController : ControllerBase
    {
        private static readonly string[] Animes = new[]
        {
            "JJK","Naruto","Bleach","One Piece","Yasuke", "Deadman Wonderland", "Tokyo Revengers", "Child of the sea", "Attack on Titan", "Akame ga kill"
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 9);
            return Animes[returnIndex].ToString();
        }


    }
}
