using api.Models;

namespace api.Interfaces.CollectToDb
{
    public interface IAsqDataDb
    {
        Task<(bool success, string errorMessage)> SetIpAddress(string ipAddress);
        Task<AsqModel> GetAsqLiveData();

    }
}