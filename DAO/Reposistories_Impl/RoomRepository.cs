using DAO.BaseModels;
using DAO.Context;
using DAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Reposistories_Impl
{
    public class RoomRepository : IRoomRepository
    {
        private readonly SmartHomeContext _context;

        public RoomRepository(SmartHomeContext context)
        {
            _context = context;
        }
        public void AddDeviceToRoom(int roomId, Device device)
        {
            throw new NotImplementedException();
        }

        public Room AddRoom(Room room)
        {
            throw new NotImplementedException();
        }

        public void DeleteRoom(int roomId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Device> GetDevicesByRoomId(int roomId)
        {
            throw new NotImplementedException();
        }

        public Room GetRoomById(int roomId)
        {
            throw new NotImplementedException();
        }

        public void RemoveDeviceFromRoom(int roomId, int deviceId)
        {
            throw new NotImplementedException();
        }

        public Room UpdateRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
