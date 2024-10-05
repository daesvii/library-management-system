using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.interfaces
{
    public interface ILibrarianRepository
    {
        IEnumerable<Librarian> GetAll();
        Librarian GetById(long id);
        void Add(Librarian librarian);
    }
}
