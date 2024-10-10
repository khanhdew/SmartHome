using DAO.BaseModels;

namespace DAO.Models.Devices;

internal class Fan : Device, IFan
{
    public void TurnOn()
    {
        throw new NotImplementedException();
    }

    public void TurnOff()
    {
        throw new NotImplementedException();
    }

    public void SetSpeed(double speed)
    {
        throw new NotImplementedException();
    }
}