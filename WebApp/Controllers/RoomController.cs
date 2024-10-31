using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
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

    [Authorize]
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
    
    public IActionResult LoadMoreRoom(int? houseId, int skip, int take)
    {
        var housesWithRooms = new Dictionary<House, IEnumerable<Room>>();
        if (houseId != null)
        {
            var house = _houseService.GetHouseById((int)houseId);
            var rooms = _houseService.GetRooms((int)houseId)
                .Skip(skip)
                .Take(take)
                .ToList();
            housesWithRooms[house] = rooms;
        }
        else
        {
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID)
                    .Skip(skip)
                    .Take(take)
                    .ToList();
                housesWithRooms[house] = rooms;
            }
        }
        return PartialView("RoomSection", housesWithRooms);
    }
    
    [HttpPost]
    public IActionResult Create(int houseId, string name, string detail)
    {
        if (ModelState.IsValid)
        {
            var newRoom = _houseService.AddRoomToHouse(houseId, new Room { Name = name, Detail = detail });
            return RedirectToAction("Index", new { houseId = houseId });
        }
        
        return View("Index");
    }
    [Authorize]
    public IActionResult Edit(int roomId)
    {
        return View("Edit", _roomService.GetRoomById(roomId));
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Room room)
    {
        if (ModelState.IsValid)
        {
            _roomService.EditRoom(room);
            return RedirectToAction("Index");
        }
        return View("Edit", room);
    }
    
    public IActionResult Delete(int roomId)
    {
        return View("Delete", _roomService.GetRoomById(roomId));
    }
    
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteRoom(int roomId)
    {
        
        _roomService.DeleteRoom(roomId);
        return RedirectToAction("Index");
    }
    
}