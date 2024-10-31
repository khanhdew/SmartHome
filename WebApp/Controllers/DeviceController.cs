using DAO.BaseModels;
using DAO.Models;
using DAO.Models.Devices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace WebApp.Controllers;

public class DeviceController : Controller
{
    private readonly IDeviceService _deviceService;
    private readonly IRoomService _roomService;
    private readonly IUserService _userService;

    public DeviceController(IDeviceService deviceService, IRoomService roomService, IUserService userService)
    {
        _deviceService = deviceService;
        _roomService = roomService;
        _userService = userService;
    }

    [Authorize]
    public IActionResult Index(int? roomId)
    {
        IEnumerable<Device> devices;
        if (roomId != null)
        {
            var room = _roomService.GetRoomById((int)roomId);
            devices = _roomService.GetDevicesByRoomId((int)roomId);
            ViewBag.RoomId = roomId;
            ViewBag.RoomName = room.Name;
        }
        else
        {
            devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId());
        }
        
        return View(devices);
    }
    
    [HttpPost]
    public IActionResult Create([Bind("Name,DeviceToken,Type,UserID,RoomID")]Device device)
    {
        _deviceService.CreateDevice(device);
        return RedirectToAction("Index");
    }
    
    public IActionResult Edit()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Edit([Bind("ID,Name,DeviceToken,Type,UserID,RoomID")]Device device)
    {
        _deviceService.EditDevice(device);
        return View();
    }
    
    public IActionResult Delete(int id)
    {
        _deviceService.DeleteDevice(id);
        return RedirectToAction("Index");
    }
    
}