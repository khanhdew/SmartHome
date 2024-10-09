using DAO.Models;

namespace Services.Models.Devices;

public class RgbLight:Device, IRgbLight
{
    public void TurnOn()
    {
        throw new NotImplementedException();
    }

    public void TurnOff()
    {
        throw new NotImplementedException();
    }

    public void SetDim(int dim)
    {
        throw new NotImplementedException();
    }

    public void SetColor(int R, int G, int B)
    {
        throw new NotImplementedException();
    }
}