using DAO.Context;
using DAO.Exceptions.UserExceptions;
using DAO.Models;
using DAO.Repositories;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Reposistories_Impl
{
    
    internal class UserRepository : IUserRepository
    {
        private readonly DbContext _context;
        public UserRepository(DbContext context)
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
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                throw new UserNotFoundException("User not found");
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public User GetUserByUsername(string username)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user == null)
            {
                throw new UserNotFoundException("User not found");
            }
            return user;
        }

        public User UpdateUser(User user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.Username == user.Username);
            if (userToUpdate == null)
            {
                throw new UserNotFoundException("User not found!");
            }
            userToUpdate.Password = user.Password;
            userToUpdate.Email = user.Email;
            userToUpdate.Role = user.Role;
            _context.Users.Update(userToUpdate);
            _context.SaveChanges();
            return userToUpdate;
        }
    }
}
