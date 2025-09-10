using DAO.BaseModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using WebApp.Utils;

namespace WebApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IHouseService _houseService;
        private readonly IUserService _userService;
        private readonly IDeviceService _deviceService;

        public RoomController(IRoomService roomService, IHouseService houseService, IUserService userService, IDeviceService deviceService)
        {
            _roomService = roomService;
            _houseService = houseService;
            _userService = userService;
            _deviceService = deviceService;
        }

        [HttpGet]
        public IActionResult GetRooms(int? houseId, int skip = 0, int take = 10)
        {
            try
            {
                var housesWithRooms = new Dictionary<House, IEnumerable<Room>>();

                if (houseId != null)
                {
                    var house = _houseService.GetHouseById((int)houseId);
                    if (house == null)
                        return NotFound(new { message = "House not found" });

                    // Check if user has access to this house
                    var houseMembers = _houseService.GetHouseMembers((int)houseId);
                    if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId()))
                        return Forbid();

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

                return Ok(new
                {
                    housesWithRooms = housesWithRooms,
                    skip = skip,
                    take = take
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpGet("search")]
        public IActionResult SearchRooms(int? houseId, string keyword)
        {
            try
            {
                var houses = _houseService.GetHousesByUserId(_userService.GetCurrentUserId());
                var roomsWithHouse = new Dictionary<House, IEnumerable<Room>>();
                
                foreach (var house in houses)
                {
                    var rooms = _houseService.GetRooms(house.ID)
                        .Where(r => StringProcessHelper.RemoveDiacritics(r.Name).ToLower()
                            .Contains(StringProcessHelper.RemoveDiacritics(keyword).ToLower()))
                        .ToList();
                    roomsWithHouse[house] = rooms;
                }

                return Ok(new { roomsWithHouse = roomsWithHouse });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            try
            {
                var room = _roomService.GetRoomById(id);
                if (room == null)
                    return NotFound(new { message = "Room not found" });

                // Check if user has access to this room's house
                var houseMembers = _houseService.GetHouseMembers((int)room.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId()))
                    return Forbid();

                return Ok(room);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpPost]
        public IActionResult CreateRoom([FromBody] CreateRoomRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                // Check if user is owner of the house
                var houseMembers = _houseService.GetHouseMembers(request.HouseId);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId() && hm.Role == "Owner"))
                    return Forbid();

                var newRoom = _houseService.AddRoomToHouse(request.HouseId, new Room { Name = request.Name, Detail = request.Detail });
                
                return CreatedAtAction(nameof(GetRoom), new { id = newRoom.ID }, newRoom);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRoom(int id, [FromBody] Room room)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                // Check if user is owner of the house
                var existingRoom = _roomService.GetRoomById(id);
                if (existingRoom == null)
                    return NotFound(new { message = "Room not found" });

                var houseMembers = _houseService.GetHouseMembers((int)existingRoom.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId() && hm.Role == "Owner"))
                    return Forbid();

                room.ID = id;
                _roomService.EditRoom(room);

                return Ok(room);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            try
            {
                // Check if user is owner of the house
                var room = _roomService.GetRoomById(id);
                if (room == null)
                    return NotFound(new { message = "Room not found" });

                var houseMembers = _houseService.GetHouseMembers((int)room.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId() && hm.Role == "Owner"))
                    return Forbid();

                _roomService.DeleteRoom(id);
                return Ok(new { message = "Room deleted successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpGet("{id}/devices")]
        public IActionResult GetRoomDevices(int id)
        {
            try
            {
                var room = _roomService.GetRoomById(id);
                if (room == null)
                    return NotFound(new { message = "Room not found" });

                // Check if user has access to this room's house
                var houseMembers = _houseService.GetHouseMembers((int)room.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId()))
                    return Forbid();

                var devices = _roomService.GetDevicesByRoomId(id);
                return Ok(new { devices = devices });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpPost("{id}/devices/{deviceId}")]
        public IActionResult AddDeviceToRoom(int id, int deviceId)
        {
            try
            {
                var room = _roomService.GetRoomById(id);
                if (room == null)
                    return NotFound(new { message = "Room not found" });

                // Check if user is owner of the house
                var houseMembers = _houseService.GetHouseMembers((int)room.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId() && hm.Role == "Owner"))
                    return Forbid();

                var device = _deviceService.GetDeviceById(deviceId);
                if (device == null)
                    return NotFound(new { message = "Device not found" });

                _roomService.AddDeviceToRoom(id, device);
                return Ok(new { message = "Device added to room successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }

        [HttpDelete("{id}/devices/{deviceId}")]
        public IActionResult RemoveDeviceFromRoom(int id, int deviceId)
        {
            try
            {
                var room = _roomService.GetRoomById(id);
                if (room == null)
                    return NotFound(new { message = "Room not found" });

                // Check if user is owner of the house
                var houseMembers = _houseService.GetHouseMembers((int)room.HouseID);
                if (!houseMembers.Any(hm => hm.UserID == _userService.GetCurrentUserId() && hm.Role == "Owner"))
                    return Forbid();

                _roomService.RemoveDeviceFromRoom(id, deviceId);
                return Ok(new { message = "Device removed from room successfully" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Internal server error" });
            }
        }
    }

    public class CreateRoomRequest
    {
        public int HouseId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
    }
} 