using DAO.BaseModels;

namespace DAO.Models.Devices;

public class Light : Device, ILight
{
    public int? Dim { get; set; }

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
        Dim = dim;
        return new { method = "setLedDim", parameters = new { dim } };
    }
}