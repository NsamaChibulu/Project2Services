using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Frontend.Models;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private AppSettings Configuration;
        public HomeController(IOptions<AppSettings> settings)
        {
            Configuration = settings.Value;
        }

        public async Task<IActionResult> Index()
        {
            var mergeService = $"{Configuration.mergeURL}/merge";
            var mergeResponseCall = await new HttpClient().GetStringAsync(mergeService);
            ViewBag.responseCall = mergeResponseCall;
            return View();
        }
    }
}