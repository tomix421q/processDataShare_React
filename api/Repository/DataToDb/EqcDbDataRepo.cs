using api.DbData;
using api.Interfaces.CollectToDb;
using api.Models;
using S7.Net;

namespace api.Repository.DataToDb
{
    public class EqcDbDataRepo : IEqcDataDb
    {
        // DB
        private readonly ApplicationDBContext _context;

        public EqcDbDataRepo(ApplicationDBContext context)
        {
            _context = context;
        }

        // IP ADRESS 
        private string _ipAddress_eqc1;
        private string _ipAddress_eqc2;
        private string _ipAddress_eqc3;
        private string _ipAddress_eqc4;
        private string _ipAddress_eqc5;
        private string _ipAddress_eqc6;
        private string _ipAddress_eqc7;
        private string _ipAddress_eqc8;

        // 
        // DATA
        // 
        public async Task<EqcModel> GetLiveDataToDb_eqc1()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc1, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc1.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc2()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc2, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc2.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc3()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc3, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc3.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc4()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc4, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc4.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc5()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc5, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc5.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc6()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc6, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc6.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc7()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc7, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc7.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }

            return eqcModel;
        }

        public async Task<EqcModel> GetLiveDataToDb_eqc8()
        {
            var eqcModel = new EqcModel();
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc8, 0, 1))
                {
                    plc.Open();
                    if (plc.IsConnected)
                    {
                        if (eqcModel.MainStepNumber == 15)
                        {
                            //actuall time
                            DateTime currentDate = DateTime.Now;
                            string formattedDate = currentDate.ToString("dd.MM.yyyy");

                            eqcModel.connection = formattedDate; //shot actual time
                            eqcModel.actualDowntime = ((ushort)await plc.ReadAsync("DB189.DBW0.0")).ConvertToShort();
                            eqcModel.ActualToolName = plc.Read(DataType.DataBlock, 189, 2, VarType.String, 20).ToString();

                            int startAdress = 258; // Adresa UDT
                            int sizeInBytes = 78; // Veľkosť UDT v bajtoch
                            int numberDB = 189; // Cislo DB blocku v plc

                            //Scan multiply
                            var udtData = await plc.ReadBytesAsync(DataType.DataBlock, numberDB, startAdress, sizeInBytes);
                            //basic info
                            eqcModel.MachineAuto = udtData[0].SelectBit(0);
                            eqcModel.ConveyorOK = udtData[0].SelectBit(1);
                            eqcModel.MainStepNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(2).Take(2).ToArray());
                            eqcModel.CycleTime = S7.Net.Types.DInt.FromByteArray(udtData.Skip(4).Take(4).ToArray()) / 10;
                            eqcModel.ProductionCurrentNum = S7.Net.Types.DInt.FromByteArray(udtData.Skip(8).Take(4).ToArray());
                            //tool
                            eqcModel.ToolHome = udtData[12].SelectBit(0);
                            eqcModel.HeaterOk = udtData[12].SelectBit(1);
                            eqcModel.ToolNumber = S7.Net.Types.Word.FromByteArray(udtData.Skip(14).Take(2).ToArray());
                            //bluemelt gluestation
                            eqcModel.BluemeltOk = udtData[17].SelectBit(0);
                            eqcModel.ActualPressure = S7.Net.Types.Real.FromByteArray(udtData.Skip(18).Take(4).ToArray());

                            eqcModel.SetAirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(22).Take(4).ToArray());
                            eqcModel.SetAirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(26).Take(4).ToArray());
                            eqcModel.SetpumpSpeed1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(30).Take(4).ToArray());

                            eqcModel.SetAirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(34).Take(4).ToArray());
                            eqcModel.SetAirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(38).Take(4).ToArray());
                            eqcModel.SetpumpSpeed2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(42).Take(4).ToArray());

                            eqcModel.SetAirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(46).Take(4).ToArray());
                            eqcModel.SetpumpSpeed3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(50).Take(4).ToArray());

                            eqcModel.Actual_AirInside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(54).Take(4).ToArray());
                            eqcModel.Actual_AirOutside1 = S7.Net.Types.Real.FromByteArray(udtData.Skip(58).Take(4).ToArray());
                            eqcModel.Actual_AirInside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(62).Take(4).ToArray());
                            eqcModel.Actual_AirOutside2 = S7.Net.Types.Real.FromByteArray(udtData.Skip(66).Take(4).ToArray());
                            eqcModel.Actual_AirInside3 = S7.Net.Types.Real.FromByteArray(udtData.Skip(70).Take(4).ToArray());
                            //Robot
                            eqcModel.RobotAutomaticMode = udtData[74].SelectBit(0);
                            eqcModel.RobotRunning = udtData[74].SelectBit(1);
                            eqcModel.RobotHome = udtData[74].SelectBit(2);
                            eqcModel.RobotConnectedGripper = udtData[74].SelectBit(3);
                            eqcModel.RobotToolNumber = S7.Net.Types.Int.FromByteArray(udtData.Skip(76).Take(2).ToArray());

                            // WRITE TO DB
                            await _context.EqcDatas_eqc8.AddAsync(eqcModel);
                            await _context.SaveChangesAsync();
                        }

                    }
                    else
                    {
                        eqcModel.connection = "Error: Unable to connect to PLC";
                    }
                }
            }
            catch (Exception ex)
            {
                eqcModel.connection = $"Error : {ex.Message}";
            }
            return eqcModel;
        }

        // 
        // IP ADRESS
        // 
        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc1(string ipAddress)
        {
            _ipAddress_eqc1 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc1, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_1 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_1 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_1: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc2(string ipAddress)
        {
            _ipAddress_eqc2 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc2, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_2 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_2 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_2: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc3(string ipAddress)
        {
            _ipAddress_eqc3 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc3, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_3 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_3 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_3: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc4(string ipAddress)
        {
            _ipAddress_eqc4 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc4, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_4 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_4 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_4: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc5(string ipAddress)
        {
            _ipAddress_eqc5 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc5, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_5 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_5 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_5: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc6(string ipAddress)
        {
            _ipAddress_eqc6 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc6, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_6 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_6 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_6: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc7(string ipAddress)
        {
            _ipAddress_eqc7 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc7, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_7 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_7 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_7: {ex.Message}");
            }
        }

        public async Task<(bool success, string errorMessage)> SetIpAddress_eqc8(string ipAddress)
        {
            _ipAddress_eqc7 = ipAddress;
            try
            {
                using (var plc = new Plc(CpuType.S71500, _ipAddress_eqc8, 0, 1))
                {
                    await plc.OpenAsync();//Connect
                    if (plc.IsConnected)
                    {
                        return (true, "Connection EQC_8 OK"); // sucess
                    }
                    else
                    {
                        return (false, "Unable connect EQC_8 to PLC");
                    }
                }
            }
            catch (Exception ex)
            {
                return (false, $"Error EQC_8: {ex.Message}");
            }
        }
    }
}