using api.Models;

namespace api.Interfaces.CollectToDb
{
    public interface IEqcDataDb
    {
        //_____________________________EQC_1_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc1(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc1();
        //_____________________________EQC_2_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc2(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc2();
        //_____________________________EQC_3_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc3(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc3();
        //_____________________________EQC_4_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc4(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc4();
        //_____________________________EQC_5_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc5(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc5();
        //_____________________________EQC_6_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc6(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc6();
        //_____________________________EQC_7_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc7(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc7();
        //_____________________________EQC_8_________________________________
        Task<(bool success, string errorMessage)> SetIpAddress_eqc8(string ipAddress);
        Task<EqcModel> GetLiveDataToDb_eqc8();
        //
    }
}