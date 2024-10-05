using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.repository;

namespace LibraryManagementSystem.services
{
    public class LibrarianService : ILibrarianService
    {
        private readonly ILibrarianRepository _librarianRepository;

        public LibrarianService(ILibrarianRepository librarianRepository)
        {
            _librarianRepository = librarianRepository;
        }

        public void AddLibrarian(Librarian librarian)
        {
            _librarianRepository.Add(librarian);
        }

        public bool login(long identification, string password)
        {
            // Try to get a user with the provided identification
            Librarian existingLibrarian = _librarianRepository.GetById(identification);

            // If no user is found with the provided identification, login fails
            if (existingLibrarian == null)
            {
                return false;
            }
            else
            {
                // Check if the provided password matches the user's password
                if (existingLibrarian.Password == password)
                {
                    return true;
                }
                else
                {
                    // Password is incorrect, login fails
                    return false;
                }
            }
        }

        public Librarian GetById(long id)
        {
            return _librarianRepository.GetById(id);
        }
    }
}
