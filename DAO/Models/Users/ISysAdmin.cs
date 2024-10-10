namespace DAO.Models.Users;

public interface ISysAdmin : IUser
{
    void DeleteAdminUser(string userName);
}