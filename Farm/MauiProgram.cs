
using Blazor.ModalDialog;
using Microsoft.AspNetCore.Components.WebView.Maui;
using Syncfusion.Blazor;

namespace Farm;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});
        
        builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddModalDialog();
		
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		//builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
