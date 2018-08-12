using FlightFinder.Client;
using FlightFinder.Client.Services;
using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<AppState>();
    }

    public void Configure(IBlazorApplicationBuilder app)
    {
        app.AddComponent<App>("app");
    }
}
