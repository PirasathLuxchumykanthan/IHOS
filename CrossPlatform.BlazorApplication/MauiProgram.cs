using Microsoft.AspNetCore.Components.WebView.Maui;

namespace CrossPlatform.BlazorApplication;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Device, Device>();
		builder.Services.AddScoped<Shared.RazorClassLibray.Loader>();
		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		#endif
		return builder.Build();
	}
}
