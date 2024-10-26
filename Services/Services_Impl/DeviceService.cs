using DAO.BaseModels;
using DAO.Models.Devices;
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
    public IDevice CreateDevice(Device device)
    {
        try
        {
            var deviceCreated = _deviceRepository.AddDevice(device);
            return deviceCreated;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IDevice EditDevice(Device device)
    {
        try
        {
            var deviceEdited = _deviceRepository.UpdateDevice(device);
            return deviceEdited;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public IEnumerable<Device> GetDevicesByHouseId(int houseId)
    {
        throw new NotImplementedException();
    }

    public IDevice GetDeviceById(int deviceId)
    {
        return _deviceRepository.GetDeviceById(deviceId);
    }

    public void DeleteDevice(int deviceId)
    {
        throw new NotImplementedException();
    }

    public TelemetryDatum AddTelemetryDatum(TelemetryDatum telemetryDatum)
    {
        try
        {
            return _deviceRepository.AddTelemetryDatum(telemetryDatum);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
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