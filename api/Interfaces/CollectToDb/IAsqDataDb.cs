using api.Models;

namespace api.Interfaces.CollectToDb
{
    public interface IAsqDataDb
    {
        //_______________________ASQ_2________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq2(string ipAddress);
        Task<AsqModel> GetLiveDataToDb_asq2();
        //_______________________ASQ_3________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq3(string ipAddress);
        Task<AsqModel> GetLiveDataToDb_asq3();
        //_______________________ASQ_4________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq4(string ipAddress);
        Task<AsqModel> GetLiveDataToDb_asq4();
        //_______________________ASQ_5________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq5(string ipAddress);
        Task<AsqModel> GetLiveDataToDb_asq5();
        //_______________________ASQ_6________________________
        Task<(bool success, string errorMessage)> SetIpAddress_asq6(string ipAddress);
        Task<AsqModel> GetLiveDataToDb_asq6();


    }
}