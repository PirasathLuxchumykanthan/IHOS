using Microsoft.AspNetCore.Components.WebView.Maui;

namespace CrossPlatform.BlazorApplication;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Device, DeviceOverwrite>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Network,NetworkOverwrite>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Definition, DefinitionOverwrite>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Loader>();

		builder.Services.AddScoped<Shared.RazorClassLibray.IO, IO>();
		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		return builder.Build();
	}
}
