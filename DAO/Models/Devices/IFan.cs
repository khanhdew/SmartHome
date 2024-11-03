namespace DAO.Models.Devices;

public interface IFan : IDevice
{
    object SetSpeed(double speed);
}