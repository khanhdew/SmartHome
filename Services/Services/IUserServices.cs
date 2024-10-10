using User = DAO.BaseModels.User;

namespace Services.Services;

public interface IUserServices
{
    User Register(string username, string password, string email);
    string Login(string username, string password);
    User EditUser(User user);
}