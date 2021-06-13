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
            var mergedResponse = $"{animesResponseCall} {mangasResponseCall}";
            return Ok(mergedResponse);
        }
    }
}