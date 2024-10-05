namespace Services.Exceptions.UserExceptions.RegisterExceptions;

public class UserExistedException:Exception
{
    public UserExistedException() : base("User is already registered")
    {
    }
}