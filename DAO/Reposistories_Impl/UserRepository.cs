using DAO.Context;
using DAO.Exceptions.UserExceptions;
using DAO.Repositories;
using Microsoft.Data.SqlClient;
using DAO.BaseModels;
using Microsoft.EntityFrameworkCore;

namespace DAO.Reposistories_Impl
{
    
    public class UserRepository : IUserRepository
    {
        private readonly SmartHomeContext _context;
        public UserRepository(SmartHomeContext context)
        {
            _context = context;
        }
        public User AddUser(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
            }catch (SqlException e)
            {
                throw new UserExistException("Error while adding user");
            }
            return user;
        }

        public void DeleteUser(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == username);
            if (user == null)
            {
                throw new UserNotFoundException("User not found");
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserName == username);
            if (user == null)
            {
                throw new UserNotFoundException("User not found");
            }
            return user;
        }

        public User GetLoggedInUser()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;
        }

        public User UpdateUser(User user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (userToUpdate == null)
            {
                throw new UserNotFoundException("User not found");
            }

            // Update only the modified properties
            // no update for id, username, null properties
            var properties = user.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (property.Name == "Id" || property.Name == "UserName" || property.GetValue(user) == null )
                {
                    continue;
                }
                property.SetValue(userToUpdate, property.GetValue(user));
            }
            _context.SaveChanges();
            return userToUpdate;
        }
    }
}
