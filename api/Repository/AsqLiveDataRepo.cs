using api.Interfaces.Live;
using api.Models;
using S7.Net;

namespace api.Repository
{
    public class AsqLiveDataRepo : IAsqLiveDataService
    {

        private string _ipAddress;

        public AsqLiveDataRepo()
        {
            // Defaultní IP adresa
            _ipAddress = "";
        }
        public async Task<AsqModel> GetAsqLiveData()
        {
            var asqModel = new AsqModel();

            try
            {
                using (var _plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))

                    // TRY CONNECT TO PLC
                    // await SetIpAddress();
                    if (_plc.IsConnected)
                    {
                        asqModel.connection = "Connection OK";

                        // Implementace logiky pro čtení dat z PLC
                        asqModel.ROB1_Downtime_Time = ((ushort)_plc.Read("DB179.DBW0.0")).ConvertToShort();
                        asqModel.ROB1_FormNumber = ((ushort)_plc.Read("DB179.DBW2.0")).ConvertToShort();
                        asqModel.ROB1_WeightActualValue = ((uint)_plc.Read("DB179.DBD4.0")).ConvertToFloat();
                        // ... další hodnoty ...

                        // Globalní hodnoty
                        asqModel.Global_RefValue = ((uint)_plc.Read("DB179.DBD40.0")).ConvertToFloat();
                        asqModel.Global_WeightTolMinus = ((uint)_plc.Read("DB179.DBD44.0")).ConvertToFloat();
                        asqModel.Global_WeightTolPlus = ((uint)_plc.Read("DB179.DBD48.0")).ConvertToFloat();
                        asqModel.Global_MixingTime = ((uint)_plc.Read("DB179.DBD54.0")).ConvertToFloat();
                    }
                    else
                    {
                        asqModel.connection = "Error: Unable to connect to PLC";
                    }
            }
            catch (Exception ex)
            {
                asqModel.connection = $"Error: {ex.Message}";
            }

            return asqModel;
        }

        public async Task<bool> SetIpAddress(string ipAddress)
        {
            // Nastavit novou IP adresu
            _ipAddress = ipAddress;

            // Pokusit se připojit s novou IP adresou
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    if (!plc.IsConnected)
                    {
                        await plc.OpenAsync();
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}