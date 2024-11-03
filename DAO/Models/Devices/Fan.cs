using DAO.BaseModels;

namespace DAO.Models.Devices;

public class Fan : Device, IFan
{
    public object TurnOn()
    {
        // return an object with method name and parameters
        return new { method = "turnOn", parameters = new { } };
    }

    public object TurnOff()
    {
        // return an object with method name and parameters
        return new { method = "turnOff", parameters = new { } };
    }

    public object SetSpeed(double speed)
    {
        // return an object with method name and parameters
        return new { method = "setSpeed", parameters = new { speed } };
    }
}