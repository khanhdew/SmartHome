using System.Security.Claims;
using DAO.BaseModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;

public class HouseController : Controller
{
    private readonly IHouseService _houseService;
    private readonly IUserService _userService;

    public HouseController(IHouseService houseService, IUserService userService)
    {
        _houseService = houseService;
        _userService = userService;
    }
    
    // GET
    public IActionResult Index()
    {
        // var uid = User.FindFirst(ClaimTypes.NameIdentifier).Value;
        var uid = _userService.GetLoggedInUser().Id;
        Console.WriteLine(uid);
        var houses = _houseService.GetHousesByUserId(uid);
        
        return View(houses);
    }
}