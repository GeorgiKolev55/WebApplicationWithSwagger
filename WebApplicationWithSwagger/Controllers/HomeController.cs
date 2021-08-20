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
        public async Task PostBookAsync(Book book)
        {

           await _bookService.AddBookAsync(book);

        }


        [HttpDelete]
        public async Task DeleteBookAsync(Book book)
        {
            
            
             await   _bookService.RemoveBookAsync(book);
           

            
        }

       
        [HttpPut]
        public async Task PutBookAsync(Book book)
        {
           
               await _bookService.UpdateBookAsync(book);
           
            
        }

     
        [HttpGet]
        public async Task<Book[]> GetAllAsync()
        {
            return await _bookService.GetAllBooksAsync();
        }

    }
}
