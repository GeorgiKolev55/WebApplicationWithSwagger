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
using WebApplicationWithSwagger.Service;

namespace WebApplicationWithSwagger.Controllers
{

    [ApiController]
    public class HomeController : Controller
    {
        private readonly BookRepository bookRepository;

        public HomeController(BookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
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

        [Route("createBook")]
        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                this.bookRepository.AddBook(book);
            }
            return Ok();
        }

        [Route("deleteBook")]
        [HttpDelete]
        public IActionResult RemoveBook(Book book)
        {
            if (ModelState.IsValid)
            {
                bookRepository.RemoveBook(book);
            }

            return Ok();
        }

        [Route("updateBook")]
        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            if (ModelState.IsValid)
            {
                this.bookRepository.UpdateBook(book);
            }

            return Ok();
            
        }

        [Route("GetAllBooks")]
        [HttpGet]
        public ActionResult<Book[]> GetAllBooks()
        {
            return this.bookRepository.GetAllBooks();
        }

    }
}
