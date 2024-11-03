using System.Text.Json;
using DAO.BaseModels;
using DAO.Repositories;
using Services.Services;
using Services.Thingsboard_Services;

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
        try
        {
            var deviceCreated =(Device) _deviceRepository.AddDevice(device);
            
            
            _deviceRepository.UpdateDevice(deviceCreated);
            return deviceCreated;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public Device EditDevice(Device device)
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

    public Device GetDeviceById(int deviceId)
    {
        return _deviceRepository.GetDeviceById(deviceId);
    }

    public IEnumerable<Device> GetDevices()
    {
        return _deviceRepository.GetAllDevices();
    }

    public IEnumerable<Device> GetDevicesByUserId(string userId)
    {
        return _deviceRepository.GetDevicesByUserId(userId);
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
    
    public bool IsDeviceOwner(string userId, int deviceId)
    {
        return _deviceRepository.IsDeviceOwner(userId, deviceId);
    }
}