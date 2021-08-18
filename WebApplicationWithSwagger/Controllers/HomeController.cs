using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Controllers
{

    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/privacy")]
        [HttpGet]
        public IActionResult Privacy()
        {
            return View();
        }


        [Route("/values")]
        [HttpGet]

        public ActionResult<IEnumerable<string>> GetValues()
        {
            return new string[] { "Value_1", "Value_2","Value_3" };
        }
        
     
    }
}
