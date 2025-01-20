using Hangfire;
using Jobs.Location;

namespace Application.Worker;

public class Worker : BackgroundService
{
    private readonly IRecurringJobManager _recurringJobManager;
    private readonly ILogger<Worker> _logger;

    public Worker(IRecurringJobManager recurringJobManager, ILogger<Worker> logger)
    {
        _recurringJobManager = recurringJobManager;
        _logger = logger;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
        }
            
        _recurringJobManager.AddOrUpdate<UpdateLocation>(
            "update-location", 
            job => job.ExecuteAsync(), 
            Cron.Minutely);

        return Task.CompletedTask;
    }
}