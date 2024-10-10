using DAO.BaseModels;

namespace DAO.Models.Users;

public class SysAdmin : User, ISysAdmin
{
    public void DeleteAdminUser(string userName)
    {
        throw new NotImplementedException();
    }
}