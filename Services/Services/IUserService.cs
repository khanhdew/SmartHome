using System.Security.Claims;
using User = DAO.BaseModels.User;

namespace Services.Services;

public interface IUserService
{
    User EditUser(User user);
    User GetUserByUsername(string username);
    User GetLoggedInUser();

    string GetCurrentUserId();
    void SetHttpContext(ClaimsPrincipal user);
    
}