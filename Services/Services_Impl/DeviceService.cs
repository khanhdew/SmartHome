using System.Text.Json;
using DAO.BaseModels;
using DAO.Models.Devices;
using DAO.Repositories;
using Services.Services;
using Services.Thingsboard_Services;

namespace Services.Services_Impl;

public class DeviceService : IDeviceService
{
    private readonly IDeviceRepository _deviceRepository;
    private readonly IThingsboardService _thingsboardService;
    
    public DeviceService(IDeviceRepository deviceRepository, IThingsboardService thingsboardService)
    {
        _deviceRepository = deviceRepository;
        _thingsboardService = thingsboardService;
    }
    public IDevice CreateDevice(Device device)
    {
        try
        {
            var deviceCreated =(Device) _deviceRepository.AddDevice(device);
            var tbDevice = _thingsboardService.CreateDevice(device);
            var root = JsonDocument.Parse(tbDevice.ToString()).RootElement;
            deviceCreated.TbDeviceId = root.GetProperty("id").GetProperty("id").GetString();
            Console.WriteLine(tbDevice.ToString());
            _deviceRepository.UpdateDevice(deviceCreated);
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

    public IEnumerable<IDevice> GetDevicesByUserId(string userId)
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
}