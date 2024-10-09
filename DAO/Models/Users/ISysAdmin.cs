using DAO.Models;

namespace Services.Models.Users;

public interface ISysAdmin : IUser
{
    void DeleteAdminUser(string userName);
}