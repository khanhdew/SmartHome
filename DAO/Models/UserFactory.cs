using Services.Models.Users;

namespace Services.Models;

public class UserFactory
{
    public BaseUser CreateUser(UserRole userRole, string username, string password, string email)
    {
        switch (userRole)
        {
            case UserRole.User:
                return new User {Username = username, Password = password, Email = email, Role = "User"};
            case UserRole.Admin:
                return new Admin {Username = username, Password = password, Email = email, Role = "Admin"};
            case UserRole.SysAdmin:
                return new SysAdmin {Username = username, Password = password, Email = email, Role = "SysAdmin"};
            default:
                throw new ArgumentException("Invalid user");
        }
    }
}