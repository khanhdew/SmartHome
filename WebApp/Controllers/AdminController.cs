using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;
[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly IHouseService _houseService;
    private readonly IDeviceService _deviceService;
    private readonly IUserService _userService;
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;

    public AdminController(IHouseService houseService, IDeviceService deviceService, IUserService userService, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _houseService = houseService;
        _deviceService = deviceService;
        _userService = userService;
        _userManager = userManager;
        _signInManager = signInManager;
    }


    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult ManageUsers()
    {
        var users = _userService.GetUsers();
        return View(users);
    }
    
    
    public IActionResult ManageHouses()
    {
        var houses = _houseService.GetHouses();
        return View(houses);
    }
    
    
    public IActionResult ManageDevices()
    {
        var devices = _deviceService.GetDevices();
        return View(devices);
    }
    
    public async Task<IActionResult> LoginAsUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        await _signInManager.SignOutAsync();
        await _signInManager.SignInAsync(user, isPersistent: false);

        return RedirectToAction("Index", "House");
    }
    
    public async Task<IActionResult> editUser(string id)
    {
        var user = await _userManager.FindByIdAsync(id);
        if (user == null)
        {
            return NotFound();
        }

        return View(user);
    }
}