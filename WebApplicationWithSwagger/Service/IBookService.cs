using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Service
{
    public interface IBookService
    {
        public Task AddBookAsync(Book book);


        public Task RemoveBookAsync(Book book);


        public Task UpdateBookAsync(Book book);


        public Task<Book[]> GetAllBooksAsync();
      
    }
}
