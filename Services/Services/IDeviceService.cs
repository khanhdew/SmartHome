using DAO.BaseModels;

namespace Services.Services;

public interface IDeviceService
{
    public Device CreateDevice(Device device);
    public Device EditDevice(Device device);
    public Device GetDeviceById(int deviceId);
    public void DeleteDevice(int deviceId);
    public TelemetryDatum AddTelemetryDatum(TelemetryDatum telemetryDatum);
    public IEnumerable<TelemetryDatum> GetTelemetryDataByDeviceId(int deviceId);
    public DeviceConfig AddDeviceConfig(DeviceConfig deviceConfig);
    public DeviceConfig GetDeviceConfigByDeviceId(int deviceId);
    public DeviceConfig UpdateDeviceConfig(DeviceConfig deviceConfig);
}