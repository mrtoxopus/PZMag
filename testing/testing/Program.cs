using System.Data;
using testing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using MySqlConnector;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

AddBlazorise(builder.Services);

await builder.Build().RunAsync();


void AddBlazorise(IServiceCollection services)
{
    var connectionString = ConnectionStringProvider.GetConnectionString();
    
    services.AddScoped<IDbConnection>(sp => 
        new MySqlConnection(connectionString));
    
    services
        .AddBlazorise();
    services
        .AddBootstrap5Providers()
        .AddFontAwesomeIcons();
}



public static class ConnectionStringProvider
{
    public static string GetConnectionString()
    {
        return File.ReadAllText("connectionString.txt").Trim();
    }
}
