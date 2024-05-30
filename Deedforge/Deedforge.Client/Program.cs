using Deedforge.Client.Services;
using Deedforge.Shared.Compendium;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IDataFetchService, DataFetchServiceProxy>();

builder.Services.AddSingleton<ICompendiumService, CompendiumService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
