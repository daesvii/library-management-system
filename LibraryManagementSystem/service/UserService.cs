using LibraryManagementSystem.interfaces;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.ui;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LibraryManagementSystem.services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;


        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool login(long identification, string password)
        {
            // Try to get a user with the provided identification
            User existingUser = _userRepository.GetById(identification);

            // If no user is found with the provided identification, login fails
            if (existingUser == null)
            {
                return false;
            }
            else
            {
                // Check if the provided password matches the user's password
                if (existingUser.Password == password)
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


        public bool AddUser(User user)
        {
            try
            {
                // Try to get a user with the same id
                User existingUser = _userRepository.GetById(user.Identification);

                // If no exception is thrown, it means there is already a user with that id
                if (existingUser != null)
                {
                    return false;
                }
                else
                {
                    // If a user with the same ID was not found, add the new user
                    _userRepository.Add(user);
                    return true;
                }
            }
            catch (FormatException)
            {
                return true;
            }
        }

        public User GetById(long id)
        {
            return _userRepository.GetById(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
