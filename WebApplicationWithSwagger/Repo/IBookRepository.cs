using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Repo
{
    public interface IBookRepository
    {
        public Task AddBookAsync(Book book);


        public Task RemoveBookAsync(Book book);


        public Task UpdateBookAsync(Book book);


        public  Task<Book[]> GetAllBooksAsync();
    }
}
