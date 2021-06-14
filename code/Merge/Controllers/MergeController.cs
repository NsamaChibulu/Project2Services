using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace servicethree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
        private IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animesService = $"{Configuration["animesURL"]}/animes";
            var animesResponseCall = await new HttpClient().GetStringAsync(animesService);
            var mangasService = $"{Configuration["mangasURL"]}/mangas";
            var mangasResponseCall = await new HttpClient().GetStringAsync(mangasService);
            var mergedResponse = $" Anime of the month is {animesResponseCall}.       Manga of the month is {mangasResponseCall}.";

            if (animesResponseCall == "Bleach"  || animesResponseCall == "Naruto" || animesResponseCall == "One Piece")
            {
                return Ok($"{mergedResponse} This is a top 3 Anime so we Highly recommend watching it !! Warning, top animes do have long episodes.");
                
                
            }
            if (animesResponseCall == "Attack on Titan" || animesResponseCall == "Akame ga Kill" || animesResponseCall == "Yasuke")
            {
                return Ok($"{mergedResponse} Oh no ! You got a reallly crap anime this time round. Enjoy I guess. Better luck next time !");


            }
            else
            {
               return Ok(mergedResponse);
            }


           
        }

    }
} 

   

