using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationWithSwagger.Models;

namespace WebApplicationWithSwagger.Repo
{
    public interface IBookRepository
    {
        public void AddBook(Book book);


        public void RemoveBook(Book book);


        public void UpdateBook(Book book);


        public  Book[] GetAllBooks();
    }
}
