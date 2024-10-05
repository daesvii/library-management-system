using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(long id);
        bool Add(User user);
    }
}
