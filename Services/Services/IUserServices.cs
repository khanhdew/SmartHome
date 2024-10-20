using User = DAO.BaseModels.User;

namespace Services.Services;

public interface IUserServices
{
    User EditUser(User user);
}