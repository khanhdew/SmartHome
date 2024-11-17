using DAO.BaseModels;

namespace DAO.Models.Devices;

public class RgbLight : Device, IRgbLight
{
    public object TurnOn()
    {
        return new { method = "turnOn", parameters = new { } };
    }

    public object TurnOff()
    {
        return new { method = "turnOff", parameters = new { } };
    }

    public object SetDim(int dim)
    {
        return new { method = "setDim", parameters = new { dim } };
    }

    public object SetColor(int r, int g, int b)
    {
        // return an object with method name and parameters
        var color = new { r, g, b };
        return new { method = "setColor", parameters = new { color } };
    }
}