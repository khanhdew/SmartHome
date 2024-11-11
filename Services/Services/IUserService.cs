using System.Security.Claims;
using User = DAO.BaseModels.User;

namespace Services.Services;

public interface IUserService
{
    User EditUser(User user);
    User GetUserByUsername(string username);
    User GetLoggedInUser();
    User? GetUserById(string userId);
    IEnumerable<User> GetUsers();

    string GetCurrentUserId();
    void SetHttpContext(ClaimsPrincipal user);

    void Login(string username, string password);
    void Logout();
}