using LibraryManagementSystem.Model;
using System.Collections.Generic;

namespace LibraryManagementSystem.services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetById(long id);
        bool AddUser(User user);
        bool login(long identification, string password);
    }
}
