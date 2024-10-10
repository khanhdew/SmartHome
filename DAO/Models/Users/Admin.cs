namespace DAO.Models.Users;

public class Admin : DAO.BaseModels.User, IAdmin
{
    public void DeleteUser(string userName)
    {
        throw new NotImplementedException();
    }

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