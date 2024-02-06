using api.Interfaces.CollectToDb;

namespace api.Services
{
    public class EqcCollectorDb : BackgroundService
    {
        readonly ILogger<EqcCollectorDb> _logger;
        private IServiceProvider _serviceProvider;

        public EqcCollectorDb(ILogger<EqcCollectorDb> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }


        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Try to connect
                using (var scope = _serviceProvider.CreateScope())
                {
                    var EqcDbDataRepo = scope.ServiceProvider.GetRequiredService<IEqcDataDb>();
                    // CHECK CONNECT IP
                    var (success_eqc1, errorMessage_eqc1) = await EqcDbDataRepo.SetIpAddress_eqc1("10.184.159.173");
                    var (success_eqc2, errorMessage_eqc2) = await EqcDbDataRepo.SetIpAddress_eqc2("10.184.159.174");
                    var (success_eqc3, errorMessage_eqc3) = await EqcDbDataRepo.SetIpAddress_eqc3("10.184.159.175");
                    var (success_eqc4, errorMessage_eqc4) = await EqcDbDataRepo.SetIpAddress_eqc4("10.184.159.176");
                    var (success_eqc5, errorMessage_eqc5) = await EqcDbDataRepo.SetIpAddress_eqc5("10.184.159.89");
                    var (success_eqc6, errorMessage_eqc6) = await EqcDbDataRepo.SetIpAddress_eqc6("10.184.159.99");
                    var (success_eqc7, errorMessage_eqc7) = await EqcDbDataRepo.SetIpAddress_eqc7("10.184.159.171");
                    var (success_eqc8, errorMessage_eqc8) = await EqcDbDataRepo.SetIpAddress_eqc8("10.184.159.101");
                    // 
                    // RESULT EQC1
                    if (success_eqc1)
                    {
                        var resultEqc1 = await EqcDbDataRepo.GetLiveDataToDb_eqc1();
                        if (resultEqc1.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc1 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC1 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC2
                    if (success_eqc2)
                    {
                        var resultEqc2 = await EqcDbDataRepo.GetLiveDataToDb_eqc2();
                        if (resultEqc2.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc2 : {time}", DateTimeOffset.Now);

                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC2 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC3
                    if (success_eqc3)
                    {
                        var resultEqc3 = await EqcDbDataRepo.GetLiveDataToDb_eqc3();
                        if (resultEqc3.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc3 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC3 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC4
                    if (success_eqc4)
                    {
                        var resultEqc4 = await EqcDbDataRepo.GetLiveDataToDb_eqc4();
                        if (resultEqc4.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc4 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC4 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC5
                    if (success_eqc5)
                    {
                        var resultEqc5 = await EqcDbDataRepo.GetLiveDataToDb_eqc5();
                        if (resultEqc5.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc5 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC5 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC6
                    if (success_eqc6)
                    {
                        var resultEqc6 = await EqcDbDataRepo.GetLiveDataToDb_eqc6();
                        if (resultEqc6.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc6 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC6 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC7
                    if (success_eqc7)
                    {
                        var resultEqc7 = await EqcDbDataRepo.GetLiveDataToDb_eqc7();
                        if (resultEqc7.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc7 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC7 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC8
                    if (success_eqc8)
                    {
                        var resultEqc8 = await EqcDbDataRepo.GetLiveDataToDb_eqc8();
                        if (resultEqc8.MainStepNumber == 15)
                            _logger.LogInformation("Database shot => eqc8 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        await Task.Delay(10000);
                        _logger.LogInformation("Problem with connection EQC8 : {time}", DateTimeOffset.Now);
                    }


                }
















                //await Task.Delay(5000, stoppingToken);
            }
        }





    }
}
