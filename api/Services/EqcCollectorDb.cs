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
                // Získání živých dat z PLC
                using (var scope = _serviceProvider.CreateScope())
                {
                    var EqcDbDataRepo = scope.ServiceProvider.GetRequiredService<IEqcDataDb>();
                    // CHECK CONNECT IP
                    var (success_eqc1, errorMessage_eqc1) = await EqcDbDataRepo.SetIpAddress_eqc1("10.184.159.173");
                    var (success_eqc2, errorMessage_eqc2) = await EqcDbDataRepo.SetIpAddress_eqc2("10.184.159.173");
                    var (success_eqc3, errorMessage_eqc3) = await EqcDbDataRepo.SetIpAddress_eqc3("10.184.159.173");
                    var (success_eqc4, errorMessage_eqc4) = await EqcDbDataRepo.SetIpAddress_eqc4("10.184.159.173");
                    var (success_eqc5, errorMessage_eqc5) = await EqcDbDataRepo.SetIpAddress_eqc5("10.184.159.173");
                    var (success_eqc6, errorMessage_eqc6) = await EqcDbDataRepo.SetIpAddress_eqc6("10.184.159.173");
                    var (success_eqc7, errorMessage_eqc7) = await EqcDbDataRepo.SetIpAddress_eqc7("10.184.159.173");
                    var (success_eqc8, errorMessage_eqc8) = await EqcDbDataRepo.SetIpAddress_eqc8("10.184.159.173");
                    // 
                    // RESULT EQC1
                    if (success_eqc1)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc1();
                        _logger.LogInformation("Database collector ready => eqc1 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC1 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC2
                    if (success_eqc2)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc2();
                        _logger.LogInformation("Database collector ready => eqc2 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC2 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC3
                    if (success_eqc3)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc3();
                        _logger.LogInformation("Database collector ready => eqc3 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC3 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC4
                    if (success_eqc4)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc4();
                        _logger.LogInformation("Database collector ready => eqc4 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC4 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC5
                    if (success_eqc5)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc5();
                        _logger.LogInformation("Database collector ready => eqc5 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC5 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC6
                    if (success_eqc6)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc6();
                        _logger.LogInformation("Database collector ready => eqc6 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC6 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC7
                    if (success_eqc7)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc7();
                        _logger.LogInformation("Database collector ready => eqc7 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC7 : {time}", DateTimeOffset.Now);
                    }
                    // 
                    // RESULT EQC8
                    if (success_eqc8)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc8();
                        _logger.LogInformation("Database collector ready => eqc8 : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC8 : {time}", DateTimeOffset.Now);
                    }


                }
















                await Task.Delay(5000, stoppingToken);
            }
        }





    }
}
