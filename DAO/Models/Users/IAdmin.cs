﻿namespace DAO.Models.Users;

public interface IAdmin : IUser
{
    void DeleteUser(string userName);
}