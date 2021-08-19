using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Context;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Service
{
    public class BookRepository
    {
        private readonly WebAppContext dbContext;
        public BookRepository(WebAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        
        public void AddBook(Book book)
        {
            this.dbContext.Books.Add(book);
            this.dbContext.SaveChanges();
           
        }

       
        public void RemoveBook(Book book)
        {
            this.dbContext.Books.Remove(book);
            this.dbContext.SaveChanges();
       
        }
        

        public void UpdateBook(Book book)
        {
            this.dbContext.Update(book);
            this.dbContext.SaveChanges();
           
        }
      

        public Book[] GetAllBooks()
        {
            return this.dbContext.Books.Where(b => b.Name != "").ToArray();

        }
    }
}
