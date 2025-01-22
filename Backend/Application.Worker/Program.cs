using Hangfire;
using Hangfire.MemoryStorage;
using Infrastructure.OpenAQClient;
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
        builder.Services.AddSingleton<IOpenAQClient, OpenAQClientRest>();

        builder.Services
            .AddHttpClient<IOpenAQClient, OpenAQClientRest>();//(client =>
            // {
            //     client.BaseAddress = new Uri(receitaWsConfig.ApiUrl);
            // }).AddPolicyHandler(retryPolicy);
        
        builder.Services.AddHostedService<Worker>();

        var host = builder.Build();
        
        host.Run();
    }

}