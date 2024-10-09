using DAO.Models;

namespace Services.Models.Users;

public interface IUser
{
    User Register(string username, string password);
    string Login(string username, string password);
    User EditUser(User user);
}