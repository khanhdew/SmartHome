using DAO.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Models.Devices;

namespace DAO.Repositories
{
    public interface IDeviceRepository
    {
        Device AddDevice(Device device);
        void DeleteDevice(int deviceId);
        Device UpdateDevice(Device device);
        Device GetDeviceById(int deviceId);
        IEnumerable<Device> GetDevicesByUserId(string userId);
        TelemetryDatum AddTelemetryDatum(TelemetryDatum telemetryDatum);
        IEnumerable<TelemetryDatum> GetTelemetryDataByDeviceId(int deviceId);
        DeviceConfig AddDeviceConfig(DeviceConfig deviceConfig);
        DeviceConfig GetDeviceConfigByDeviceId(int deviceId);
        DeviceConfig UpdateDeviceConfig(DeviceConfig deviceConfig);
        bool IsDeviceOwner(string userId, int deviceId);
        IEnumerable<Device> GetAllDevices();
    }
}
