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
using DAO.BaseModels;

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

        public User UpdateUser(User user)
        {
            var userToUpdate = _context.Users.FirstOrDefault(u => u.UserName == user.UserName);
            if (userToUpdate == null)
            {
                throw new UserNotFoundException("User not found!");
            }
            userToUpdate.PasswordHash = user.PasswordHash;
            userToUpdate.Email = user.Email;
            _context.Users.Update(userToUpdate);
            _context.SaveChanges();
            return userToUpdate;
        }
    }
}
