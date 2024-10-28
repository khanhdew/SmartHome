using DAO.BaseModels;

namespace DAO.Models.Devices;

public interface IDevice  
{
    void TurnOn();
    void TurnOff();
}