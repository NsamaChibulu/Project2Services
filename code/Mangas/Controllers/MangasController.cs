using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace serviceone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MangasController : ControllerBase
    {
        private static readonly string[] Mangas = new[]
        {
            "Berserk","The Promised Neverland","Bleach","Blue Lock",
        };

        [HttpGet]
        public ActionResult<string> Get()
        {
            var rnd = new Random();
            var returnIndex = rnd.Next(0, 4);
            return Mangas[returnIndex].ToString();
        }
    }
}
