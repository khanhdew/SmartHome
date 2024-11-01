using System.Text.Json;
using System.Text.Json.Nodes;
using Configuration;
using DAO.BaseModels;
using DAO.Models;
using DAO.Models.Devices;
using Services.Services;
using Services.Thingsboard_Services.BaseModel;

namespace Services.Thingsboard_Services;

public class ThingsboardService : IThingsboardService
{
    private Token _adminToken;
    private readonly IDeviceService _deviceService;
    public ThingsboardService(IDeviceService deviceService)
    {
        _deviceService = deviceService;
        _adminToken = GetAdminToken();
    }
    public Token? Login(Account account)
    {
        return new Request<Token>(SystemConfiguration.ThingsboardServer + "api/auth/login", "{\"username\":\"" + account.Username + "\",\"password\":\"" + account.Password + "\"}", null).Post();
    }

    public Token GetAdminToken()
    {
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

    public object AssignDeviceToCustomer(string deviceId, string customerId)
    {
        throw new NotImplementedException();
    }

    public object? ControlDevice(int deviceId, string command)
    {
        var temp = _deviceService.GetDeviceById(deviceId);
        if (temp == null) return null;
        TelemetryDatum telemetryDatum = new()
        {
            DeviceID = temp.ID,
            Body = command
        };
        _deviceService.AddTelemetryDatum(telemetryDatum);
        // string jsonData = JsonSerializer.Serialize(command, new JsonSerializerOptions { WriteIndented = true });
        return new Request<object?>(SystemConfiguration.ThingsboardServer + $"api/rpc/oneway/{deviceId}", command,
            _adminToken).Post();
    }

    private object decodeControlCommand(Device device,string command, int? dim = null, int? R = null, int? G = null, int? B = null)
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