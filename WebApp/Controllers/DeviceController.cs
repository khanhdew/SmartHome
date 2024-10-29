using DAO.BaseModels;
using DAO.Models;
using DAO.Models.Devices;
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

    // GET
    public IActionResult Index(int? roomId)
    {
        var roomsWithDevices = new Dictionary<Room, IEnumerable<Device>>();
        if (roomId != null)
        {
            var room = _roomService.GetRoomById((int)roomId);
            var devices = _roomService.GetDevicesByRoomId((int)roomId).Cast<Device>();
            roomsWithDevices[room] = devices;
            ViewBag.RoomId = roomId;
        }
        else
        {
            var devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId()).Cast<Device>();
            foreach (var device in devices)
            {
                var room = _roomService.GetRoomById(device.Room.ID);
                if (roomsWithDevices.ContainsKey(room))
                {
                    roomsWithDevices[room] = roomsWithDevices[room].Append(device);
                }
                else
                {
                    roomsWithDevices[room] = new List<Device> { device };
                }
            }
        }
        
        return View(roomsWithDevices);
    }
    [HttpPost]
    public IActionResult Create(Device device)
    {
        _deviceService.CreateDevice(device);
        return RedirectToAction("Index");
    }
}