using DAO.BaseModels;

namespace Services.Services;

public interface IHouseService
{
    public House CreateHouse(string name, string address);
    public House EditHouse(House house);
    public IEnumerable<House> GetHousesByUserId(string userId);
    public IEnumerable<Room> GetRooms(int houseId);
    public Room GetRoom(int roomId);
    public Room AddRoomToHouse(int houseId, Room room);
    public void RemoveRoomFromHouse(int houseId, int roomId);
    public void AddHouseMember(string userId, int houseId, string role);
    public void RemoveHouseMember(string userId, int houseId);
    
}