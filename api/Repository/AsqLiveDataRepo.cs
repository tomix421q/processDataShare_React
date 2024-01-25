using api.Dtos.Asq;
using api.Interfaces.Live;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using S7.Net;

namespace api.Repo
{
    public class AsqLiveDataRepo : IAsqLive
    {

        private readonly AsqModel _model;

        public AsqLiveDataRepo(AsqModel model)
        {
            _model = model;
        }

        public async Task<AsqModel> GetLiveData()
        {

            try
            {

                using (var plc_asq1 = new Plc(CpuType.S71500, "10.184.159.241", 0, 1))
                {
                    await plc_asq1.OpenAsync();//Connect

                    if (plc_asq1.IsConnected)
                    {
                        _model.connection = "Connection OK";

                        //ROB1
                        _model.ROB1_Downtime_Time = ((ushort)plc_asq1.Read("DB179.DBW0.0")).ConvertToShort();
                        _model.ROB1_FormNumber = ((ushort)plc_asq1.Read("DB179.DBW2.0")).ConvertToShort();
                        _model.ROB1_WeightActualValue = ((uint)plc_asq1.Read("DB179.DBD4.0")).ConvertToFloat();
                        _model.ROB1_Temperature = ((uint)plc_asq1.Read("DB179.DBD8.0")).ConvertToFloat();
                        _model.ROB1_SetTemperature = ((uint)plc_asq1.Read("DB179.DBD12.0")).ConvertToFloat();
                        _model.ROB1_TimeDrying = ((uint)plc_asq1.Read("DB179.DBD16.0")).ConvertToFloat();
                        //ROB2
                        _model.ROB2_Downtime_Time = ((ushort)plc_asq1.Read("DB179.DBW20.0")).ConvertToShort();
                        _model.ROB2_FormNumber = ((ushort)plc_asq1.Read("DB179.DBW22.0")).ConvertToShort();
                        _model.ROB2_WeightActualValue = ((uint)plc_asq1.Read("DB179.DBD24.0")).ConvertToFloat();
                        _model.ROB2_Temperature = ((uint)plc_asq1.Read("DB179.DBD28.0")).ConvertToFloat();
                        _model.ROB2_SetTemperature = ((uint)plc_asq1.Read("DB179.DBD32.0")).ConvertToFloat();
                        _model.ROB2_TimeDrying = ((uint)plc_asq1.Read("DB179.DBD36.0")).ConvertToFloat();
                        //Global
                        _model.Global_RefValue = ((uint)plc_asq1.Read("DB179.DBD40.0")).ConvertToFloat();
                        _model.Global_WeightTolMinus = ((uint)plc_asq1.Read("DB179.DBD44.0")).ConvertToFloat();
                        _model.Global_WeightTolPlus = ((uint)plc_asq1.Read("DB179.DBD48.0")).ConvertToFloat();
                        _model.Global_MixingTime = ((uint)plc_asq1.Read("DB179.DBD54.0")).ConvertToFloat();

                    }
                    else
                    {
                        _model.connection = "Error please reload page...";
                    };
                }
            }
            catch (Exception ex)
            {
                _model.connection = ex.Message;
            }

            return _model;
        }
    }
}