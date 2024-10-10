using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.BaseModels;

namespace DAO.Repositories
{
    public interface IUserRepository
    {
        User AddUser(User user);
        void DeleteUser(string username);
        User UpdateUser(User user);
        User GetUserByUsername(string username);
    }
}
