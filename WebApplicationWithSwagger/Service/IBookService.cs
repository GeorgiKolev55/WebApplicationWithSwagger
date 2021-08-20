using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Service
{
    public interface IBookService
    {
        public void AddBook(Book book);


        public void RemoveBook(Book book);


        public void UpdateBook(Book book);


        public Book[] GetAllBooks();
      
    }
}
