using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void AddBook(Book book)
        {
            _bookRepository.Add(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }

        public IEnumerable<Book> SearchBooksByTitle(string searchTerm)
        {
            return _bookRepository.SearchBooksByTitle(searchTerm);
        }

        public IEnumerable<Book> SearchBooksByAuthor(string searchAuthor)
        {
            return _bookRepository.SearchBooksByAuthor(searchAuthor);
        }

        public IEnumerable<Book> SearchBooksByCategory(string category)
        {
            return _bookRepository.SearchBooksByCategory(category);
        }


        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }
    }
}
