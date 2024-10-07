namespace Services.Models.Devices;

public interface ILight : IDevice
{
    void SetDim(int dim);
}