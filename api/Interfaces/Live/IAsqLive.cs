using api.Dtos.Asq;
using api.Models;

namespace api.Interfaces.Live
{
    public interface IAsqLive
    {
        Task<AsqModel> GetLiveData();
    }
}