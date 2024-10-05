using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int id);
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int id);

        IEnumerable<Book> SearchBooksByTitle(string searchTerm);
        IEnumerable<Book> SearchBooksByAuthor(string searchAuthor);
        IEnumerable<Book> SearchBooksByCategory(string category);
    }
}
