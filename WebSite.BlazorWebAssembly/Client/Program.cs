using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebSite.BlazorWebAssembly.Client;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("main");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<Shared.RazorClassLibray.Device,DeviceOverwrite>();
builder.Services.AddScoped<Shared.RazorClassLibray.Network, NetworkOverwrite>();
builder.Services.AddScoped<Shared.RazorClassLibray.Definition>();
builder.Services.AddScoped<Shared.RazorClassLibray.Connection,ConnectionOverwrite>();

builder.Services.AddScoped<Shared.RazorClassLibray.Loader>();


builder.Services.AddScoped<Shared.RazorClassLibray.IO, IO>();
await builder.Build().RunAsync();
