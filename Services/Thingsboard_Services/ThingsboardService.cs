using System.Text.Json;
using System.Text.Json.Nodes;
using Configuration;
using DAO.BaseModels;
using Services.Thingsboard_Services.BaseModel;

namespace Services.Thingsboard_Services;

public class ThingsboardService : IThingsboardService
{
    private Token _adminToken;
    public ThingsboardService()
    {
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

    public object? ControlDevice(string deviceId, object data)
    {
        string jsonData = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
        return new Request<object?>(SystemConfiguration.ThingsboardServer + $"api/rpc/oneway/{deviceId}", jsonData,
            _adminToken).Post();
    }
}