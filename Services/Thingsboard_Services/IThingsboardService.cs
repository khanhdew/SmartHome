﻿using DAO.BaseModels;
using Services.Thingsboard_Services.BaseModel;

namespace Services.Thingsboard_Services;

public interface IThingsboardService
{
    public Token? Login(Account account);
    public Token GetAdminToken();
    public object CreateCustomerAccount(Account account);
    public object? CreateDevice(Device device);
    public object AssignDeviceToCustomer(string deviceId, string customerId);
    public object? ControlDevice(string deviceId, object data);
    
}