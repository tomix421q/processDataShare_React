using api.Interfaces.CollectToDb;

namespace api.ServicesWorkers
{
    public class AsqCollectorDb : BackgroundService
    {
        readonly ILogger<AsqCollectorDb> _logger;

        private IServiceProvider _serviceProvider;

        public AsqCollectorDb(ILogger<AsqCollectorDb> logger, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _serviceProvider = serviceProvider;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service started");



        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Service stopped");
            return Task.CompletedTask;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Získání živých dat z PLC
                using (var scope = _serviceProvider.CreateScope())
                {
                    var asqDataDb = scope.ServiceProvider.GetRequiredService<IAsqDataDb>();
                    var (success, errorMessage) = await asqDataDb.SetIpAddress("10.184.159.109");
                    if (success)
                    {
                        await asqDataDb.GetAsqLiveData();
                        _logger.LogInformation("Database shot at : {time}", DateTimeOffset.Now);
                    }
                }
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}