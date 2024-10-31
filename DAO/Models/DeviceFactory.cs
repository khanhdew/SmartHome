using DAO.BaseModels;
using DAO.Models.Devices;

namespace DAO.Models;

public class DeviceFactory
{
    public static Device CreateDevice(string deviceType, string name)
    {
        switch (deviceType)
        {
            case "Light":
                return new Light { Name = name, Type = "Light", DeviceToken = GenerateDeviceToken() };
            case "RgbLight":
                return new RgbLight { Name = name, Type = "RgbLight", DeviceToken = GenerateDeviceToken() };
            case "Fan":
                return new Fan { Name = name, Type = "Fan", DeviceToken = GenerateDeviceToken() };
            default:
                throw new ArgumentException("Invalid device type");
        }
    }

    private static string GenerateDeviceToken()
    {
        var allChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        var random = new Random();
        var resultToken = new string(
            Enumerable.Repeat(allChar, 8)
                .Select(token => token[random.Next(token.Length)]).ToArray());

        var deviceToken = resultToken;
        return deviceToken;
    }
}