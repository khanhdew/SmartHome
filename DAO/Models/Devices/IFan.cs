namespace Services.Models.Devices;

public interface IFan: IDevice
{
    void SetSpeed(double speed);
}