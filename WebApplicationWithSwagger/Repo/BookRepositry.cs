using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Context;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Repo
{
    public class BookRepositry : IBookRepository
    {
        private readonly WebAppContext _appContext;
        public BookRepositry(WebAppContext appContext)
        {
            _appContext = appContext;
        }
        public async Task AddBookAsync(Book book)
        {
            await _appContext.AddAsync(book);

            await _appContext.SaveChangesAsync();
        }

        public async Task<Book[]> GetAllBooksAsync()
        {
            return await _appContext.Books.ToArrayAsync();
        }

        public async Task RemoveBookAsync(Book book)
        {
           await Task.Run(() =>

             _appContext.Remove(book)

            );

            await _appContext.SaveChangesAsync();
        }

        public async Task UpdateBookAsync(Book book)
        {
            await Task.Run(() =>

             _appContext.Update(book)

            );

            await _appContext.SaveChangesAsync();
        }
    }
}
