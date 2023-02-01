using dymaptic.GeoBlazor.Core;

using GeoBlazorPoc1;
using GeoBlazorPoc1.Services;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>() { ["ArcGISApiKey"] = "YOUR_KEY" });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddHttpClient<ITheftReportService, TheftReportService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<ITheftReportService, TheftReportService>();

builder.Services.AddLogging();
builder.Services.AddMudServices();
builder.Services.AddGeoBlazor();

await builder.Build().RunAsync();
