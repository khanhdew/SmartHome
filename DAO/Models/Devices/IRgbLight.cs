namespace DAO.Models.Devices;

public interface IRgbLight : ILight
{
    object SetColor(int R, int G, int B);
}