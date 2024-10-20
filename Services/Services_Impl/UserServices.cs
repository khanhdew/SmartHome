using DAO.Exceptions.UserExceptions;
using DAO.Models;
using DAO.Models.Users;
using DAO.Repositories;
using Services.Services;
using User = DAO.BaseModels.User;

namespace Services.Services_Impl;

public class UserServices : IUserServices
{
    private readonly IUserRepository _userRepository;
    public UserServices(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public User EditUser(User user)
    {
        var userToUpdate = _userRepository.GetUserByUsername(user.UserName);
        if (userToUpdate == null)
        {
            throw new UserNotFoundException("User not found");
        }
        userToUpdate = user;
        _userRepository.UpdateUser(userToUpdate);
        return userToUpdate;
    }
}