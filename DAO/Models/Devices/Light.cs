using DAO.BaseModels;

namespace DAO.Models.Devices;

public class Light : Device, ILight
{
    public int? Dim { get; set; }

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
}