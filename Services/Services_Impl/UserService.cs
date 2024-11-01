using DAO.Exceptions.UserExceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using DAO.Repositories;
using Services.Services;
using User = DAO.BaseModels.User;

namespace Services.Services_Impl;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly UserManager<User> _userManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    public UserService(IUserRepository userRepository, UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
    {
        _userRepository = userRepository;
        _userManager = userManager;
        _httpContextAccessor = httpContextAccessor;
    }
    public User EditUser(User user)
    {
        var userToUpdate = _userRepository.GetUserByUsername(user.UserName);
        if (userToUpdate == null)
        {
            throw new UserNotFoundException("User not found");
        }
        userToUpdate = user;
        _userRepository.UpdateUser(userToUpdate);
        return userToUpdate;
    }

    public User GetUserByUsername(string username)
    {
        return _userRepository.GetUserByUsername(username);
    }

    public IEnumerable<User> GetUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public string GetCurrentUserId()
    {
        return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
    }

    public async Task<User> GetCurrentUserAsync()
    {
        return await _userManager.GetUserAsync(_httpContextAccessor.HttpContext?.User);
    }
    public User GetLoggedInUser()
    {
        return GetCurrentUserAsync().GetAwaiter().GetResult();
    }

    public User? GetUserById(string userId)
    {
        return _userRepository.GetUserById(userId);
    }

    public void SetHttpContext(ClaimsPrincipal user)
    {
        var context = new DefaultHttpContext();
        context.User = user;
        _httpContextAccessor.HttpContext = context;
    }
}