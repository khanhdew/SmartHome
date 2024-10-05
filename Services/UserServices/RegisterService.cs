using DAO.Context;
using DAO.Models;
namespace Services.UserServices;

public class RegisterService
{
    private DbContext _context;
    public void RegisterUser(DbContext dbContext)
    {
        _context = dbContext;
    }
    
}