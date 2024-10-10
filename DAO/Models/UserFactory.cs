using DAO.Models.Users;

namespace DAO.Models;

public class UserFactory
{
    public BaseModels.User CreateUser(UserRole userRole, string username, string password, string email)
    {
        switch (userRole)
        {
            case UserRole.User:
                return new User { UserName = username, PasswordHash = password, Email = email };
            case UserRole.Admin:
                return new Admin { UserName = username, PasswordHash = password, Email = email };
            case UserRole.SysAdmin:
                return new SysAdmin { UserName = username, PasswordHash = password, Email = email };
            default:
                throw new ArgumentException("Invalid user");
        }
    }
}