namespace DAO.Models.Devices;

public interface IRgbLight : ILight
{
    void SetColor(int R, int G, int B);
}