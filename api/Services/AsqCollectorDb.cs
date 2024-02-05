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

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}