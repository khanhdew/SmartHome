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
        IDevice AddDevice(Device device);
        void DeleteDevice(int deviceId);
        IDevice UpdateDevice(Device device);
        IDevice GetDeviceById(int deviceId);
        IEnumerable<IDevice> GetDevicesByUserId(string userId);
        TelemetryDatum AddTelemetryDatum(TelemetryDatum telemetryDatum);
        IEnumerable<TelemetryDatum> GetTelemetryDataByDeviceId(int deviceId);
        DeviceConfig AddDeviceConfig(DeviceConfig deviceConfig);
        DeviceConfig GetDeviceConfigByDeviceId(int deviceId);
        DeviceConfig UpdateDeviceConfig(DeviceConfig deviceConfig);
        
        
    }
}
