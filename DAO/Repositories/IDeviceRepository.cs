using DAO.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Repositories
{
    public interface IDeviceRepository
    {
        Device AddDevice(Device device);
        void DeleteDevice(string deviceName);
        Device UpdateDevice(Device device);
        Device GetDeviceByName(string deviceName);
        Device GetDeviceById(string deviceId);
        IEnumerable<Device> GetAllDevices();
    }
}
