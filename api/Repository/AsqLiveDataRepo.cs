using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using api.Interfaces.Live;
using api.Models;
using S7.Net;
using S7.Net.Types;

namespace api.Repository
{
    public class AsqLiveDataRepo : IAsqLiveDataService
    {

        private string _ipAddress;
        private string _ConnectMes;
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
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    plc.Open();//Connect
                    if (plc.IsConnected)
                    {
                        asqModel.connection = "Connection OK";

                        //ROB1
                        asqModel.ROB1_Downtime_Time = ((ushort)plc.Read("DB179.DBW0.0")).ConvertToShort();
                        asqModel.ROB1_FormNumber = ((ushort)plc.Read("DB179.DBW2.0")).ConvertToShort();
                        asqModel.ROB1_WeightActualValue = ((uint)plc.Read("DB179.DBD4.0")).ConvertToFloat();
                        asqModel.ROB1_Temperature = ((uint)plc.Read("DB179.DBD8.0")).ConvertToFloat();
                        asqModel.ROB1_SetTemperature = ((uint)plc.Read("DB179.DBD12.0")).ConvertToFloat();
                        asqModel.ROB1_TimeDrying = ((uint)plc.Read("DB179.DBD16.0")).ConvertToFloat();
                        //ROB2
                        asqModel.ROB2_Downtime_Time = ((ushort)plc.Read("DB179.DBW20.0")).ConvertToShort();
                        asqModel.ROB2_FormNumber = ((ushort)plc.Read("DB179.DBW22.0")).ConvertToShort();
                        asqModel.ROB2_WeightActualValue = ((uint)plc.Read("DB179.DBD24.0")).ConvertToFloat();
                        asqModel.ROB2_Temperature = ((uint)plc.Read("DB179.DBD28.0")).ConvertToFloat();
                        asqModel.ROB2_SetTemperature = ((uint)plc.Read("DB179.DBD32.0")).ConvertToFloat();
                        asqModel.ROB2_TimeDrying = ((uint)plc.Read("DB179.DBD36.0")).ConvertToFloat();
                        //Global
                        asqModel.Global_RefValue = ((uint)plc.Read("DB179.DBD40.0")).ConvertToFloat();
                        asqModel.Global_WeightTolMinus = ((uint)plc.Read("DB179.DBD44.0")).ConvertToFloat();
                        asqModel.Global_WeightTolPlus = ((uint)plc.Read("DB179.DBD48.0")).ConvertToFloat();
                        asqModel.Global_MixingTime = ((uint)plc.Read("DB179.DBD54.0")).ConvertToFloat();
                    }
                    else
                    {
                        asqModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                asqModel.connection = $"Error: {ex.Message}";
            }

            return asqModel;
        }

        async Task<bool> IAsqLiveDataService.SetIpAddress(string ipAddress)
        {
            _ipAddress = ipAddress;
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

        Task<string> IAsqLiveDataService.ConnectionStatus()
        {

            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress, 0, 1))
                {
                    if (plc.IsConnected)
                    {
                        _ConnectMes = "OKEY";
                    }
                }

            }
            catch (Exception ex)
            {
                _ConnectMes = $"Error: {ex.Message}";

            }


            return Task.FromResult(_ConnectMes);
        }

    }
}