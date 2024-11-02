using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;

public class AdminController : Controller
{
    private readonly IHouseService _houseService;
    private readonly IDeviceService _deviceService;
    private readonly IUserService _userService;

    public AdminController(IHouseService houseService, IDeviceService deviceService, IUserService userService)
    {
        _houseService = houseService;
        _deviceService = deviceService;
        _userService = userService;
    }


    [Authorize(Roles = "Admin")]
    public IActionResult Index()
    {
        return View();
    }
    
    [Authorize(Roles = "Admin")]
    public IActionResult ManageUsers()
    {
        var users = _userService.GetUsers();
        return View(users);
    }
    
    
    [Authorize(Roles = "Admin")]
    public IActionResult ManageHouses()
    {
        var houses = _houseService.GetHouses();
        return View(houses);
    }
    
    [Authorize(Roles = "Admin")]
    public IActionResult ManageDevices()
    {
        var devices = _deviceService.GetDevices();
        return View(devices);
    }
    
}