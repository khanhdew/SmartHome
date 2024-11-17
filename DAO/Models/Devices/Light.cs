using DAO.BaseModels;

namespace DAO.Models.Devices;

public class Light : Device, ILight
{
    public int? Dim { get; set; }

    public object TurnOn()
    {
        return new { method = "setLedStatus", parameters = 1 };
    }

    public object TurnOff()
    {
        return new { method = "setLedStatus", parameters = 0 };
    }

    public object SetDim(int dim)
    {
        Dim = dim;
        return new { method = "setLedDim", parameters = new { dim } };
    }
}