using Hangfire;
using Hangfire.MemoryStorage;
using Jobs.Location;

namespace Application.Worker;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);
        
        builder.Services.AddHangfire(config => config.UseMemoryStorage());
        builder.Services.AddHangfireServer();
        
        builder.Services.AddTransient<UpdateLocation>();
        
        builder.Services.AddHostedService<Worker>();

        var host = builder.Build();
        
        host.Run();
    }

}