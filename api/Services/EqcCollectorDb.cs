
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
                    // EQC_1
                    var (success_eqc1, errorMessage_eqc1) = await EqcDbDataRepo.SetIpAddress_eqc1("10.184.159.173");
                    if (success_eqc1)
                    {
                        await EqcDbDataRepo.GetLiveDataToDb_eqc1();
                        _logger.LogInformation("Database shot at : {time}", DateTimeOffset.Now);
                    }
                    else
                    {
                        _logger.LogInformation("Problem with connection EQC1 : {time}", DateTimeOffset.Now);
                    }

                }
















                await Task.Delay(5000, stoppingToken);
            }
        }





    }
}
