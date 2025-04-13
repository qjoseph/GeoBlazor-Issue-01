using dymaptic.GeoBlazor.Core;

using GeoBlazorPoc1.Services;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>() { ["ArcGISApiKey"] = "YOUR_KEY" });

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
//builder.Services.AddHttpClient<ITheftReportService, TheftReportService>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
builder.Services.AddScoped<ITheftReportService, TheftReportService>();

builder.Services.AddLogging();
builder.Services.AddMudServices();
builder.Services.AddGeoBlazor(builder.Configuration);

await builder.Build().RunAsync();
