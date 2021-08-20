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

        
        public void AddBook(Book book)
        {

          _bookRepository.AddBook(book);
           
        }

       
        public void RemoveBook(Book book)
        {

            _bookRepository.RemoveBook(book);
            
        }
        

        public void UpdateBook(Book book)
        {

            _bookRepository.UpdateBook(book);
           
        }
      

       

        public Book[] GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
