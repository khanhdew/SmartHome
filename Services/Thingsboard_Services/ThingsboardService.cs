using Configuration;
using DAO.BaseModels;
using DAO.Models.Devices;
using Microsoft.Extensions.Logging;
using Services.Services;
using Services.Thingsboard_Services.BaseModel;
using System.Text.Json;

namespace Services.Thingsboard_Services;

public class ThingsboardService : IThingsboardService
{
    private Token _adminToken;
    private readonly IDeviceService _deviceService;
    private readonly ILogger<ThingsboardService> _logger;

    public ThingsboardService(IDeviceService deviceService, ILogger<ThingsboardService> logger)
    {
        _deviceService = deviceService;
        _logger = logger;
        _adminToken = GetAdminToken();
    }
    public Token? Login(Account account)
    {
        return new Request<Token>(SystemConfiguration.ThingsboardServer + "api/auth/login", "{\"username\":\"" + account.Username + "\",\"password\":\"" + account.Password + "\"}", null).Post();
    }

    public Token GetAdminToken()
    {
        if (_adminToken != null) return _adminToken;
        return new Request<Token>(SystemConfiguration.ThingsboardServer + "api/auth/login", "{\"username\":\"" + SystemConfiguration.AdminUsername + "\",\"password\":\"" + SystemConfiguration.AdminPassword + "\"}", null).Post()!;
    }

    public object CreateCustomerAccount(Account account)
    {
        throw new NotImplementedException();
    }

    public object? CreateDevice(Device device)
    {
        var deviceData = new
        {
            device = new
            {
                name = device.Name,
                label = "",
                additionalInfo = new
                {
                    gateway = false,
                    description = "",
                    overwriteActivityTime = false
                }
            },
            credentials = new
            {
                credentialsType = "ACCESS_TOKEN",
                credentialsId = device.DeviceToken
            }
        };
        string jsonData = JsonSerializer.Serialize(deviceData, new JsonSerializerOptions { WriteIndented = true });
        return new Request<object?>(SystemConfiguration.ThingsboardServer + "api/device-with-credentials", jsonData, _adminToken).Post();
    }

    public object? DeleteDevice(int deviceId)
    {
        var temp = _deviceService.GetDeviceById(deviceId);
        if (temp == null) return null;
        try
        {
            return new Request<object?>(SystemConfiguration.ThingsboardServer + $"api/device/{temp.TbDeviceId}", null, _adminToken).Delete();
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
            throw;
        }
        catch (UnauthorizedAccessException e)
        {
            _logger.LogError(e, "UnauthorizedAccessException: {Message}", e.Message);
            throw new UnauthorizedAccessException("Unauthorized");
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e, "ArgumentException: {Message}", e.Message);
            throw new ArgumentException("Device already registered with this device token");
        }
        catch (TimeoutException e)
        {
            _logger.LogError(e, "TimeoutException: {Message}", e.Message);
            throw new TimeoutException("Device is offline");
        }
        catch (KeyNotFoundException e)
        {
            _logger.LogError(e, "KeyNotFoundException: {Message}", e.Message);
            throw new KeyNotFoundException("Device not found");
        }
    }

    public object AssignDeviceToCustomer(string deviceId, string customerId)
    {
        throw new NotImplementedException();
    }

    public object? ControlDevice(int deviceId, string command)
    {
        var temp = _deviceService.GetDeviceById(deviceId);
        try
        {
            var response = new Request<object?>(
                SystemConfiguration.ThingsboardServer + $"api/rpc/oneway/{temp.TbDeviceId}",
                command,
                _adminToken).Post();

            TelemetryData telemetryData = new()
            {
                DeviceID = temp.ID,
                Body = command
            };
            _deviceService.AddTelemetryDatum(telemetryData);
            return response;
        }
        catch (UnauthorizedAccessException e)
        {
            _logger.LogError(e, "UnauthorizedAccessException: {Message}", e.Message);
            throw new UnauthorizedAccessException("Unauthorized");
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e, "ArgumentException: {Message}", e.Message);
            throw new ArgumentException("Device already registered with this device token");
        }
        catch (TimeoutException e)
        {
            _logger.LogError(e, "TimeoutException: {Message}", e.Message);
            throw new TimeoutException("Device is offline");
        }
        catch (KeyNotFoundException e)
        {
            _logger.LogError(e, "KeyNotFoundException: {Message}", e.Message);
            throw new KeyNotFoundException("Device not found");
        }
    }

    public object? ControlDevice(int deviceId, object command)
    {
        var temp = _deviceService.GetDeviceById(deviceId);
        try
        {
            var response = new Request<object?>(
                SystemConfiguration.ThingsboardServer + $"api/rpc/oneway/{temp.TbDeviceId}",
                JsonSerializer.Serialize(command),
                _adminToken).Post();

            TelemetryData telemetryData = new()
            {
                DeviceID = temp.ID,
                Body = JsonSerializer.Serialize(command)
            };
            _deviceService.AddTelemetryDatum(telemetryData);
            return response;
        }
        catch (UnauthorizedAccessException e)
        {
            _logger.LogError(e, "UnauthorizedAccessException: {Message}", e.Message);
            throw new UnauthorizedAccessException("Unauthorized");
        }
        catch (ArgumentException e)
        {
            _logger.LogError(e, "ArgumentException: {Message}", e.Message);
            throw new ArgumentException("Device already registered with this device token");
        }
        catch (TimeoutException e)
        {
            _logger.LogError(e, "TimeoutException: {Message}", e.Message);
            throw new TimeoutException("Device is offline");
        }
        catch (KeyNotFoundException e)
        {
            _logger.LogError(e, "KeyNotFoundException: {Message}", e.Message);
            throw new KeyNotFoundException("Device not found");
        }
    }

    private object decodeControlCommand(Device device, string command, int? dim = null, int? R = null, int? G = null, int? B = null)
    {
        switch (command)
        {
            case "turnOn":
                return device switch
                {
                    Fan f => f.TurnOn(),
                    RgbLight r => r.TurnOn(),
                    Light l => l.TurnOn(),
                    _ => null
                };
            case "turnOff":
                return device switch
                {
                    Fan f => f.TurnOff(),
                    RgbLight r => r.TurnOff(),
                    Light l => l.TurnOff(),
                    _ => null
                };
            case "setDim":
                return device switch
                {
                    RgbLight r => r.SetDim(dim.Value),
                    Light l => l.SetDim(dim.Value),
                    _ => null
                };
            case "setColor":
                return device is RgbLight rgbLight ? rgbLight.SetColor(R.Value, G.Value, B.Value) : null;
            case "setSpeed":
                return device is Fan fan ? fan.SetSpeed(dim.Value) : null;
            default:
                return null;
        }
    }

    public object? ControlDevice(int deviceId, string command, int? dim = null, int? R = null, int? G = null, int? B = null)
    {
        var temp = _deviceService.GetDeviceById(deviceId);
        if (temp == null) return null;
        object controlCommand = decodeControlCommand(temp, command, dim, R, G, B);
        string jsonData = JsonSerializer.Serialize(controlCommand, new JsonSerializerOptions { WriteIndented = true });
        return new Request<object?>(SystemConfiguration.ThingsboardServer + $"api/rpc/oneway/{deviceId}", jsonData,
            _adminToken).Post();
    }
}