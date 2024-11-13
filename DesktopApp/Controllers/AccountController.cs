using Microsoft.AspNetCore.Identity;
using Services.Services;

namespace DesktopApp.Controllers;

public class AccountController
{
    private readonly IUserService _userService;
    
    public AccountController(IUserService userService)
    {
        _userService = userService;
    }
    
    public void Login(string username, string password, bool persistent)
    {
        _userService.Login(username, password, persistent);
    }
}