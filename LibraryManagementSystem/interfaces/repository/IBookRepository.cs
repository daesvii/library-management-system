using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAll();
        Book GetById(int id);
        void Add(Book book);
        void Update(Book book);
        void Delete(int id);

        IEnumerable<Book> SearchBooksByTitle(string title);
        IEnumerable<Book> SearchBooksByAuthor(string searchAuthor);
        IEnumerable<Book> SearchBooksByCategory(string category);
    }
}
