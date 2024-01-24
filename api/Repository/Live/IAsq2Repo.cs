using api.Dtos.Asq;
using api.Interfaces.Live;
using api.Models;
using S7.Net;

namespace api.Repository.Live
{
    public class IAsqRepo : IAsqLive
    {
        public Task<AsqDto> GetLiveData()
        {

            AsqDto Asq2Model = new();
            try
            {
                using (var plc_asq2 = new Plc(CpuType.S71500, "10.184.159.109", 0, 1))
                {
                    plc_asq2.Open();//Connect_

                    if (plc_asq2.IsConnected)
                    {
                        Asq2Model.connection = "Connection OK";

                        //ROB1
                        Asq2Model.ROB1_Downtime_Time = ((ushort)plc_asq2.Read("DB179.DBW0.0")).ConvertToShort();
                        Asq2Model.ROB1_FormNumber = ((ushort)plc_asq2.Read("DB179.DBW2.0")).ConvertToShort();
                        Asq2Model.ROB1_WeightActualValue = ((uint)plc_asq2.Read("DB179.DBD4.0")).ConvertToFloat();
                        Asq2Model.ROB1_Temperature = ((uint)plc_asq2.Read("DB179.DBD8.0")).ConvertToFloat();
                        Asq2Model.ROB1_SetTemperature = ((uint)plc_asq2.Read("DB179.DBD12.0")).ConvertToFloat();
                        Asq2Model.ROB1_TimeDrying = ((uint)plc_asq2.Read("DB179.DBD16.0")).ConvertToFloat();
                        //ROB2
                        Asq2Model.ROB2_Downtime_Time = ((ushort)plc_asq2.Read("DB179.DBW20.0")).ConvertToShort();
                        Asq2Model.ROB2_FormNumber = ((ushort)plc_asq2.Read("DB179.DBW22.0")).ConvertToShort();
                        Asq2Model.ROB2_WeightActualValue = ((uint)plc_asq2.Read("DB179.DBD24.0")).ConvertToFloat();
                        Asq2Model.ROB2_Temperature = ((uint)plc_asq2.Read("DB179.DBD28.0")).ConvertToFloat();
                        Asq2Model.ROB2_SetTemperature = ((uint)plc_asq2.Read("DB179.DBD32.0")).ConvertToFloat();
                        Asq2Model.ROB2_TimeDrying = ((uint)plc_asq2.Read("DB179.DBD36.0")).ConvertToFloat();
                        //Global
                        Asq2Model.Global_RefValue = ((uint)plc_asq2.Read("DB179.DBD40.0")).ConvertToFloat();
                        Asq2Model.Global_WeightTolMinus = ((uint)plc_asq2.Read("DB179.DBD44.0")).ConvertToFloat();
                        Asq2Model.Global_WeightTolPlus = ((uint)plc_asq2.Read("DB179.DBD48.0")).ConvertToFloat();
                        Asq2Model.Global_MixingTime = ((uint)plc_asq2.Read("DB179.DBD54.0")).ConvertToFloat();
                        Asq2Model.Global_GoWeightAfter = ((ushort)plc_asq2.Read("DB179.DBW0.0")).ConvertToShort();
                    }
                    else
                    {
                        Asq2Model.connection = "Error please reload page...";
                    };
                }
            }
            catch (Exception ex)
            {
                Asq2Model.connection = ex.Message;
            }

            return Asq2Model;






        }
    }
}