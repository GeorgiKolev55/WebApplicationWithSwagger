using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using WebApplicationWithSwagger.Context;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Controllers
{

    [ApiController]
    public class HomeController : Controller
    {
        private readonly WebAppContext webAppContext;

        public HomeController(WebAppContext webAppContext)
        {
            this.webAppContext = webAppContext;
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

        [Route("create")]
        [HttpPost]
        public IActionResult AddBook(Book book) {
            this.webAppContext.Books.Add(book);
            this.webAppContext.SaveChanges();
            return Ok();
        }

        [Route("delete")]
        [HttpDelete]
        public IActionResult RemoveBook(Book book)
        {
            this.webAppContext.Books.Remove(book);
            this.webAppContext.SaveChanges();

            return Ok();
        }
     
    }
}
