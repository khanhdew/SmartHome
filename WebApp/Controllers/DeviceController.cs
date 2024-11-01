using System.Text.Json;
using DAO.BaseModels;
using DAO.Models;
using DAO.Models.Devices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Thingsboard_Services;
using WebApp.Utils;

namespace WebApp.Controllers;

public class DeviceController : Controller
{
    private readonly IDeviceService _deviceService;
    private readonly IRoomService _roomService;
    private readonly IUserService _userService;
    private readonly IHouseService _houseService;
    private readonly IThingsboardService _thingsboardService;

    public DeviceController(IDeviceService deviceService, IRoomService roomService, IUserService userService, IHouseService houseService, IThingsboardService thingsboardService)
    {
        _deviceService = deviceService;
        _roomService = roomService;
        _userService = userService;
        _houseService = houseService;
        _thingsboardService = thingsboardService;
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
            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var houseDevices = new List<Device>();
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    houseDevices.AddRange(_roomService.GetDevicesByRoomId(room.ID));
                }
                
                devices = devices.Concat(houseDevices);
            }
            
        }
        devices = devices.Take(10).ToList();
        return View(devices);
    }
    
    
    
    [HttpPost]
    public IActionResult Create([Bind("Name,DeviceToken,Type,UserID,RoomID")]Device device)
    {
        var deviceCreated = _deviceService.CreateDevice(device);
        var tbDevice = _thingsboardService.CreateDevice(deviceCreated);
        var root = JsonDocument.Parse(tbDevice.ToString()).RootElement;
        deviceCreated.TbDeviceId = root.GetProperty("id").GetProperty("id").GetString();
        Console.WriteLine(tbDevice.ToString());
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

    public IActionResult LoadMoreDevices(int? roomId,int skip, int take)
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
            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var houseDevices = new List<Device>();
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    houseDevices.AddRange(_roomService.GetDevicesByRoomId(room.ID));
                }
                
                devices = devices.Concat(houseDevices);
            }
            
        }
        devices = devices.Skip(skip).Take(take).ToList();
        return PartialView("DeviceSection", devices);
    }
    
    public IActionResult Search(int? roomId, string keyword)
    {
        IEnumerable<Device> devices;
        if (roomId != null)
        {
            devices = _roomService.GetDevicesByRoomId((int)roomId)
                .Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower().Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()))
                .ToList();
        }
        else
        {
            devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId())
                .Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower().Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()))
                .ToList();
            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var houseDevices = new List<Device>();
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    houseDevices.AddRange(_roomService.GetDevicesByRoomId(room.ID));
                }
                
                devices = devices.Concat(houseDevices).Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower().Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()));
            }
        }
        return PartialView("DeviceSection", devices);
    }
    
    public IActionResult Control(int id, string command)
    {
        _thingsboardService.ControlDevice(id, command);
        return RedirectToAction("Index");
    }
}