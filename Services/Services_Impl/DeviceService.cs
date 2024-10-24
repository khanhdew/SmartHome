using DAO.BaseModels;
using DAO.Repositories;
using Services.Services;

namespace Services.Services_Impl;

public class DeviceService : IDeviceService
{
    private readonly IDeviceRepository _deviceRepository;
    
    public DeviceService(IDeviceRepository deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }
    public Device CreateDevice(Device device)
    {
        throw new NotImplementedException();
    }

    public Device EditDevice(Device device)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Device> GetDevicesByHouseId(int houseId)
    {
        throw new NotImplementedException();
    }

    public Device GetDeviceById(int deviceId)
    {
        throw new NotImplementedException();
    }

    public void DeleteDevice(int deviceId)
    {
        throw new NotImplementedException();
    }

    public TelemetryDatum AddTelemetryDatum(TelemetryDatum telemetryDatum)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<TelemetryDatum> GetTelemetryDataByDeviceId(int deviceId)
    {
        throw new NotImplementedException();
    }

    public DeviceConfig AddDeviceConfig(DeviceConfig deviceConfig)
    {
        throw new NotImplementedException();
    }

    public DeviceConfig GetDeviceConfigByDeviceId(int deviceId)
    {
        throw new NotImplementedException();
    }

    public DeviceConfig UpdateDeviceConfig(DeviceConfig deviceConfig)
    {
        throw new NotImplementedException();
    }
}