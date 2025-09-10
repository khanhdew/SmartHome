using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Thingsboard_Services;
using System.Text.Json;
using WebApp.Utils;

namespace WebApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;
        private readonly IRoomService _roomService;
        private readonly IUserService _userService;
        private readonly IHouseService _houseService;
        private readonly IThingsboardService _thingsboardService;
        private readonly ILogger<DeviceController> _logger;

        public DeviceController(
            IDeviceService deviceService, 
            IRoomService roomService, 
            IUserService userService,
            IHouseService houseService, 
            IThingsboardService thingsboardService, 
            ILogger<DeviceController> logger)
        {
            _deviceService = deviceService;
            _roomService = roomService;
            _userService = userService;
            _houseService = houseService;
            _thingsboardService = thingsboardService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetDevices(int? roomId, int skip = 0, int take = 10)
        {
            try
            {
                Dictionary<int, int> deviceMap = new Dictionary<int, int>();
                IEnumerable<Device> devices;

                if (roomId != null)
                {
                    var room = _roomService.GetRoomById((int)roomId);
                    if (room == null)
                        return NotFound(new { message = "Room not found" });

                    devices = _roomService.GetDevicesByRoomId((int)roomId);
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
                                devices = devices.Append(device);
                            }
                        }
                    }
                }

                var result = devices.Skip(skip).Take(take).ToList();
                return Ok(new
                {
                    devices = result,
                    total = devices.Count(),
                    skip = skip,
                    take = take
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting devices");
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpGet("search")]
        public IActionResult SearchDevices(int? roomId, string keyword, int skip = 0, int take = 10)
        {
            try
            {
                Dictionary<int, int> deviceMap = new Dictionary<int, int>();
                IEnumerable<Device> devices;

                if (roomId != null)
                {
                    var room = _roomService.GetRoomById((int)roomId);
                    if (room == null)
                        return NotFound(new { message = "Room not found" });

                    devices = _roomService.GetDevicesByRoomId((int)roomId)
                        .Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
                            .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()));
                }
                else
                {
                    devices = _deviceService.GetDevicesByUserId(_userService.GetCurrentUserId())
                        .Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
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
                            var houseDevices = _roomService.GetDevicesByRoomId(room.ID)
                                .Where(d => StringProcessHelper.RemoveDiacritics(d.Name).ToLower()
                                    .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()));
                            foreach (var device in houseDevices)
                            {
                                if (!deviceMap.TryAdd(device.ID, 1))
                                    continue;
                                devices = devices.Append(device);
                            }
                        }
                    }
                }

                var result = devices.Skip(skip).Take(take).ToList();
                return Ok(new
                {
                    devices = result,
                    total = devices.Count(),
                    skip = skip,
                    take = take
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error searching devices");
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetDevice(int id)
        {
            try
            {
                var device = _deviceService.GetDeviceById(id);
                if (device == null)
                    return NotFound(new { message = "Device not found" });

                if (!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
                    return Forbid();

                return Ok(device);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting device {DeviceId}", id);
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpPost]
        public IActionResult CreateDevice([FromBody] Device device)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var tempDevice = device;
                tempDevice.Name = StringProcessHelper.RemoveDiacritics(device.Name);
                
                var tbDevice = _thingsboardService.CreateDevice(tempDevice);
                var root = JsonDocument.Parse(tbDevice.ToString()).RootElement;
                device.TbDeviceId = root.GetProperty("id").GetProperty("id").GetString();
                
                var deviceCreated = _deviceService.CreateDevice(device);
                
                return CreatedAtAction(nameof(GetDevice), new { id = deviceCreated.ID }, deviceCreated);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating device");
                return StatusCode(500, new { message = "Error while creating device", details = ex.Message });
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDevice(int id, [FromBody] Device device)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                if (!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
                    return Forbid();

                device.ID = id;
                _deviceService.EditDevice(device);
                
                return Ok(device);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating device {DeviceId}", id);
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDevice(int id)
        {
            try
            {
                if (!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
                    return Forbid();

                _deviceService.DeleteDevice(id);
                return Ok(new { message = "Device deleted successfully" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting device {DeviceId}", id);
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpPost("{id}/control")]
        public IActionResult ControlDevice(int id, [FromBody] DeviceControlRequest request)
        {
            try
            {
                if (!_deviceService.IsDeviceOwner(_userService.GetCurrentUserId(), id))
                    return Forbid();

                _thingsboardService.ControlDevice(id, request.Command);
                return Ok(new { message = "Device control command sent successfully" });
            }
            catch (UnauthorizedAccessException ex)
            {
                _logger.LogError(ex, "UnauthorizedAccessException: {Message}", ex.Message);
                return StatusCode(401, new { message = "Unauthorized access while controlling device", details = ex.Message });
            }
            catch (ArgumentException ex)
            {
                _logger.LogError(ex, "ArgumentException: {Message}", ex.Message);
                return StatusCode(400, new { message = "Invalid argument while controlling device", details = ex.Message });
            }
            catch (TimeoutException ex)
            {
                _logger.LogError(ex, "TimeoutException: {Message}", ex.Message);
                return StatusCode(504, new { message = "Request timed out while controlling device", details = ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                _logger.LogError(ex, "KeyNotFoundException: {Message}", ex.Message);
                return StatusCode(404, new { message = "Device not registered", details = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred: {Message}", ex.Message);
                return StatusCode(500, new { message = "An unexpected error occurred while controlling device", details = "Please check the server logs for more details." });
            }
        }
    }

    public class DeviceControlRequest
    {
        public string Command { get; set; }
    }
} 