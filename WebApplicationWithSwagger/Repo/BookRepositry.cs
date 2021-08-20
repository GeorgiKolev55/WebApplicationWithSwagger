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
        public void AddBook(Book book)
        {
            _appContext.Add(book);

            _appContext.SaveChanges();
        }

        public Book[] GetAllBooks()
        {
            return _appContext.Books.ToArray();
        }

        public void RemoveBook(Book book)
        {
            _appContext.Remove(book);

             _appContext.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _appContext.Update(book);
         
             _appContext.SaveChanges();
        }
    }
}
