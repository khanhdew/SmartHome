using DAO.BaseModels;
using DAO.Models.Devices;

namespace Services.Services;

public interface IRoomService
{
    public Room EditRoom(Room room);
    public IEnumerable<Room> GetRoomsByHouseId(int houseId);
    public Room GetRoomById(int roomId);
    public void DeleteRoom(int roomId);
    public IEnumerable<IDevice> GetDevicesByRoomId(int roomId);
    public IDevice AddDeviceToRoom(int roomId, Device device);
    public void RemoveDeviceFromRoom(int roomId, int deviceId);
}