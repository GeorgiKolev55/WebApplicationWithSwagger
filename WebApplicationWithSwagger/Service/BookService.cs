using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Context;
using WebApplicationWithSwagger.Models;
using WebApplicationWithSwagger.Repo;

namespace WebApplicationWithSwagger.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        
        public async Task AddBookAsync(Book book)
        {

          await  _bookRepository.AddBookAsync(book);
           
        }

       
        public async Task RemoveBookAsync(Book book)
        {

            await _bookRepository.RemoveBookAsync(book);
            
        }
        

        public async Task UpdateBookAsync(Book book)
        {

            await _bookRepository.UpdateBookAsync(book);
           
        }
      

       

        public async Task<Book[]> GetAllBooksAsync()
        {
            return await _bookRepository.GetAllBooksAsync();
        }
    }
}
