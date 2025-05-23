﻿using System.Text.Json;
using DAO.BaseModels;
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
    private readonly ILogger<DeviceController> _logger;

    public DeviceController(IDeviceService deviceService, IRoomService roomService, IUserService userService,
        IHouseService houseService, IThingsboardService thingsboardService, ILogger<DeviceController> logger)
    {
        _deviceService = deviceService;
        _roomService = roomService;
        _userService = userService;
        _houseService = houseService;
        _thingsboardService = thingsboardService;
        _logger = logger;
    }

    [Authorize]
    public IActionResult Index(int? roomId)
    {
        
        Dictionary<int,int> deviceMap = new Dictionary<int, int>();
        
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
            devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId()).ToList();
            foreach (var device in devices)
            {
                deviceMap[device.ID] = 1;
            }

            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    var houseDevices = _roomService.GetDevicesByRoomId(room.ID);
                    foreach (var device in houseDevices)
                    {
                        if (!deviceMap.TryAdd(device.ID, 1))
                            continue;
                        devices.Append(device);
                    }
                }
            }
        }
      
        return View(devices.Take(10).ToList());
    }

    [Authorize]
    public IActionResult LoadMoreDevices(int? roomId, int skip, int take)
    {
        Dictionary<int,int> deviceMap = new Dictionary<int, int>();
        
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
            devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId()).ToList();
            foreach (var device in devices)
            {
                deviceMap[device.ID] = 1;
            }

            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    var houseDevices = _roomService.GetDevicesByRoomId(room.ID);
                    foreach (var device in houseDevices)
                    {
                        if (!deviceMap.TryAdd(device.ID, 1))
                            continue;
                        devices.Append(device);
                    }
                }
            }
        }
        return PartialView("DeviceSection", devices.Skip(skip).Take(take).ToList());
    }

    [Authorize]
    public IActionResult Search(int? roomId, string keyword)
    {
        Dictionary<int,int> deviceMap = new Dictionary<int, int>();
        
        IEnumerable<Device> devices;
        if (roomId != null)
        {
            var room = _roomService.GetRoomById((int)roomId);
            devices = _roomService.GetDevicesByRoomId((int)roomId).Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
                .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()));

            ViewBag.RoomId = roomId;
            ViewBag.RoomName = room.Name;
        }
        else
        {
            devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId()).Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
                .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower())).ToList();
            foreach (var device in devices)
            {
                deviceMap[device.ID] = 1;
            }

            // get devices from joined house's rooms
            var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
            foreach (var house in houses)
            {
                var rooms = _houseService.GetRooms(house.ID);
                foreach (var room in rooms)
                {
                    var houseDevices = _roomService.GetDevicesByRoomId(room.ID).Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
                        .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()));
                    foreach (var device in houseDevices)
                    {
                        if (!deviceMap.TryAdd(device.ID, 1))
                            continue;
                        devices.Append(device);
                    }
                }
            }
        }
        return PartialView("DeviceSection", devices.Take(10).ToList());
    }

    [HttpPost]
    public IActionResult Create(Device device)
    {
        var tempDevice = device;
        tempDevice.Name = StringProcessHelper.RemoveDiacritics(device.Name);
        try
        {
            var tbDevice = _thingsboardService.CreateDevice(tempDevice);
            Console.WriteLine("\u001b[32m" + tbDevice.ToString() + "\u001b[0m");
            var root = JsonDocument.Parse(tbDevice.ToString()).RootElement;
            device.TbDeviceId = root.GetProperty("id").GetProperty("id").GetString();
            var deviceCreated = _deviceService.CreateDevice(device);
        }
        catch (Exception e)
        {
            ModelState.AddModelError("Error", e.Message);
            _logger.LogError(e, "Error while creating device");
            return StatusCode(400, new { message = "Error while creating device", details = e.Message });
        }
        return RedirectToAction("Index");
    }

    [Authorize]
    public IActionResult Edit(int id)
    {
        var device = _deviceService.GetDeviceById(id);
        if(!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
        {
            return RedirectToAction("AccessDenied", "Account");
        }
        return View(device);
    }

    [HttpPost]
    public IActionResult Edit([Bind("ID,Name,DeviceToken,Type,UserID,RoomID")] Device device)
    {
        _deviceService.EditDevice(device);
        return View();
    }

    public IActionResult Delete(int id)
    {
        if(!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
        {
            return RedirectToAction("AccessDenied", "Account");
        }
        _deviceService.DeleteDevice(id);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Control(int id, string command)
    {
        try
        {
            _thingsboardService.ControlDevice(id, command);
        }
        catch (UnauthorizedAccessException e)
        {
            _logger.LogError(e, "UnauthorizedAccessException: {Message}", e.Message);
            return StatusCode(401, new { message = "Unauthorized access while controlling device", details = e.Message });
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e, "ArgumentException: {Message}", e.Message);
            return StatusCode(400, new { message = "Invalid argument while controlling device", details = e.Message });
        }
        catch (TimeoutException e)
        {
            _logger.LogError(e, "TimeoutException: {Message}", e.Message);
            return StatusCode(504, new { message = "Request timed out while controlling device", details = e.Message });
        }
        catch (KeyNotFoundException e)
        {
            _logger.LogError(e, "KeyNotFoundException: {Message}", e.Message);
            return StatusCode(404, new { message = "Device not registered", details = e.Message });
        }
        catch (Exception e)
        {
            _logger.LogError(e, "An unexpected error occurred: {Message}", e.Message);
            return StatusCode(500, new { message = "An unexpected error occurred while controlling device", details = "Please check the server logs for more details." });
        }
        return Ok();
    }
}