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
    [Route("[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

  
       [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public IActionResult PostBook(Book book)
        {

           _bookService.AddBook(book);
            return Ok();

        }


        [HttpDelete]
        public IActionResult DeleteBoo(Book book)
        {
            
             _bookService.RemoveBook(book);

            return Ok();
            
        }

       
        [HttpPut]
        public IActionResult PutBook(Book book)
        {
                _bookService.UpdateBook(book);

                return Ok();
        }

     
        [HttpGet]
        public ActionResult<Book[]> GetAll()
        {
            return  _bookService.GetAllBooks();
        }

    }
}
