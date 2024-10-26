using Services.Thingsboard_Services.BaseModel;

namespace Services.Thingsboard_Services;

public interface IThingsboardService
{
    public Response<Token> Login(Account account);
    public Response<object> CreateAccount(Account account);
    public Response<object> CreateDevice(Device device);
    public Response<object> AssignDeviceToCustomer(string deviceId, string customerId);
    
}
