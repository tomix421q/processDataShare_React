using api.Models;

namespace api.Interfaces.Live
{
    public interface IAsqLiveDataService
    {
        Task<bool> SetIpAddress(string ipAddress);
        Task<string> ConnectionStatus();
        Task<AsqModel> GetAsqLiveData();
    }
}