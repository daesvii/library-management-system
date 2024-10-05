using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public interface ILibrarianService
    {
        void AddLibrarian(Librarian librarian);
        Librarian GetById(long id);
        bool login(long identification, string password);
    }
}
