using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    internal interface IUserRepository
    {
        User AddUser(User user);
        void DeleteUser(string username);
        User UpdateUser(User user);
        User GetUserByUsername(string username);
    }
}
