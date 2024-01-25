using api.Dtos.Asq;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using S7.Net;
using api.Interfaces.Live;


namespace Stackup.Api.Controllers
{

    [Route("api/asqmachines")]
    [ApiController]
    public class AsqController : ControllerBase
    {


        private readonly IAsqLive _asqRepo;

        public AsqController(IAsqLive asqRepo)
        {
            _asqRepo = asqRepo;
        }


        // 
        //________________________Asq_2___________________________
        // 
        [HttpGet]
        [Route("asq2")]
        public async Task<IActionResult> Asq2Live()
        {
            var asq2Data = await _asqRepo.GetLiveData();
            return Ok(asq2Data);
        }



        // 
        //________________________Asq_3___________________________
        // 
        [HttpGet]
        [Route("asq3")]
        public IActionResult Asq3()
        {
            AsqModel Asq3Model = LoadPLCData_Asq3(); // nacitat data plc (ajax)
            return Ok(Asq3Model);
        }

        private AsqModel LoadPLCData_Asq3()
        {
            AsqModel Asq3Model = new();
            try
            {

                using (var plc_asq3 = new Plc(CpuType.S71500, "10.184.159.240", 0, 1))
                {
                    plc_asq3.Open();//Connect

                    if (plc_asq3.IsConnected)
                    {
                        Asq3Model.connection = "Connection OK";

                        //ROB1
                        Asq3Model.ROB1_Downtime_Time = ((ushort)plc_asq3.Read("DB179.DBW0.0")).ConvertToShort();
                        Asq3Model.ROB1_FormNumber = ((ushort)plc_asq3.Read("DB179.DBW2.0")).ConvertToShort();
                        Asq3Model.ROB1_WeightActualValue = ((uint)plc_asq3.Read("DB179.DBD4.0")).ConvertToFloat();
                        Asq3Model.ROB1_Temperature = ((uint)plc_asq3.Read("DB179.DBD8.0")).ConvertToFloat();
                        Asq3Model.ROB1_SetTemperature = ((uint)plc_asq3.Read("DB179.DBD12.0")).ConvertToFloat();
                        Asq3Model.ROB1_TimeDrying = ((uint)plc_asq3.Read("DB179.DBD16.0")).ConvertToFloat();
                        //ROB2
                        Asq3Model.ROB2_Downtime_Time = ((ushort)plc_asq3.Read("DB179.DBW20.0")).ConvertToShort();
                        Asq3Model.ROB2_FormNumber = ((ushort)plc_asq3.Read("DB179.DBW22.0")).ConvertToShort();
                        Asq3Model.ROB2_WeightActualValue = ((uint)plc_asq3.Read("DB179.DBD24.0")).ConvertToFloat();
                        Asq3Model.ROB2_Temperature = ((uint)plc_asq3.Read("DB179.DBD28.0")).ConvertToFloat();
                        Asq3Model.ROB2_SetTemperature = ((uint)plc_asq3.Read("DB179.DBD32.0")).ConvertToFloat();
                        Asq3Model.ROB2_TimeDrying = ((uint)plc_asq3.Read("DB179.DBD36.0")).ConvertToFloat();
                        //Global
                        Asq3Model.Global_RefValue = ((uint)plc_asq3.Read("DB179.DBD40.0")).ConvertToFloat();
                        Asq3Model.Global_WeightTolMinus = ((uint)plc_asq3.Read("DB179.DBD44.0")).ConvertToFloat();
                        Asq3Model.Global_WeightTolPlus = ((uint)plc_asq3.Read("DB179.DBD48.0")).ConvertToFloat();
                        Asq3Model.Global_MixingTime = ((uint)plc_asq3.Read("DB179.DBD54.0")).ConvertToFloat();
                        Asq3Model.Global_GoWeightAfter = ((ushort)plc_asq3.Read("DB179.DBW0.0")).ConvertToShort();
                    }
                    else
                    {
                        Asq3Model.connection = "Error please reload page...";
                    };
                }
            }
            catch (Exception ex)
            {
                Asq3Model.connection = ex.Message;
            }
            return Asq3Model;
        }



    }
}


