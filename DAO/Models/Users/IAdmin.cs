namespace Services.Models.Users;

public interface IAdmin : IUser
{
    void DeleteUser(string userName);
}