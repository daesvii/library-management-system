using LibraryManagementSystem.data;
using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.repository
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext dbContext;

        public UserRepository(LibraryContext context)
        {
            dbContext = context;
        }

        public IEnumerable<User> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public User GetById(long id)
        {
            return dbContext.Users.Find(id);
        }

        public bool Add(User user)
        {
            try
            {
                dbContext.Users.Add(user);
                dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
