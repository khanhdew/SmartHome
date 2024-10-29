using DAO.BaseModels;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;

public class RoomController : Controller
{
    private readonly IRoomService _roomService;
    private readonly IHouseService _houseService;
    private readonly IUserService _userService;

    public RoomController(IRoomService roomService, IHouseService houseService, IUserService userService)
    {
        _roomService = roomService;
        _houseService = houseService;
        _userService = userService;
    }

    // GET
    public IActionResult Index(int? houseId)
    {
        var housesWithRooms = new Dictionary<House, IEnumerable<Room>>();

        if (houseId != null)
        {
            var house = _houseService.GetHouseById((int)houseId);
            var rooms = _houseService.GetRooms((int)houseId);
            housesWithRooms[house] = rooms;
            ViewBag.HouseId = houseId;
        }
        else
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                housesWithRooms[house] = rooms;
            }
        }
        
        return View(housesWithRooms);
    }
    
    [HttpPost]
    public IActionResult Create(int houseId, string name, string detail)
    {
        if (ModelState.IsValid)
        {
            var newRoom = _houseService.AddRoomToHouse(houseId, new Room { Name = name, Detail = detail });
            return RedirectToAction("Index", new { houseId = houseId });
        }
        return PartialView("Create");
    }
    
}