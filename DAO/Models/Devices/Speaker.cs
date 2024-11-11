using DAO.BaseModels;

namespace DAO.Models.Devices;

public class Speaker:Device, IDevice
{
    public object SetUrl(string url)
    {
        // return an object with method name and parameters
        return new { method = "setUrl", parameters = new { url } };
    }
    
    public object Pause()
    {
        // return an object with method name and parameters
        return new { method = "pause", parameters = new { } };
    }
    
    public object Resume()
    {
        // return an object with method name and parameters
        return new { method = "resume", parameters = new { } };
    }
}