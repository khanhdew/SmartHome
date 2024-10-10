namespace DAO.Models.Users;

public class User : BaseModels.User, IUser
{
    public User Register(string username, string password)
    {
        throw new NotImplementedException();
    }

    public string Login(string username, string password)
    {
        throw new NotImplementedException();
    }

    public User EditUser(User user)
    {
        throw new NotImplementedException();
    }
}