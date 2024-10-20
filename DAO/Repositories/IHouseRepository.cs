using DAO.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public interface IHouseRepository
    {
        House AddHouse(House house);
        void DeleteHouse(int houseId);
        House UpdateHouse(House house);
        IEnumerable<House> GetHouseByUserID(string userId);
        IEnumerable<House> GetAllHouses();
        House GetHouseById(int houseId);
        void AddHouseMember(string userId, int houseId);
        void RemoveHouseMember(string userId, int houseId);
        void AddRoomToHouse(int houseId, Room room);
        void RemoveRoomFromHouse(int houseId, int roomId);

        IEnumerable<Room> GetRoomsByHouseId(int houseId);
    }
}
