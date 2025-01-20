using Microsoft.Extensions.Logging;

namespace Jobs.Location;

public class UpdateLocation
{
    private readonly ILogger<UpdateLocation> _logger;
    
    public UpdateLocation(ILogger<UpdateLocation> logger)
    {
        _logger = logger;
    }
    
    public Task ExecuteAsync()
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation("******************** UpdateLocation executed at: {time}", DateTimeOffset.Now);
        }
        
        return Task.CompletedTask;
    }
}