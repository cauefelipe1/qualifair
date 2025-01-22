using Infrastructure.OpenAQClient;
using Microsoft.Extensions.Logging;

namespace Jobs.Location;

public class UpdateLocation
{
    private readonly ILogger<UpdateLocation> _logger;
    private readonly IOpenAQClient _openAQClient;
    
    public UpdateLocation(ILogger<UpdateLocation> logger, IOpenAQClient openAQClient)
    {
        _logger = logger;
        _openAQClient = openAQClient;
    }
    
    public async Task ExecuteAsync()
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation("******************** UpdateLocation executed at: {time}", DateTimeOffset.Now);
        }

        var locations = await _openAQClient.GetLocations();
        
        Console.WriteLine(locations);
    }
}