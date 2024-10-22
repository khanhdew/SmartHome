using DAO.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public interface IRoomRepository
    {
        Room AddRoom(Room room);
        void DeleteRoom(int roomId);
        Room UpdateRoom(Room room);
        Room GetRoomById(int roomId);
        void AddDeviceToRoom(int roomId, Device device);
        void RemoveDeviceFromRoom(int roomId, int deviceId);
        IEnumerable<Device> GetDevicesByRoomId(int roomId);

    }
}
