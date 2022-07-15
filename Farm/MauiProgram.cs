
using Blazor.ModalDialog;
using Blazor.Toastr;
using MatBlazor;
using Microsoft.AspNetCore.Components.WebView.Maui;
using MudBlazor;
using MudBlazor.Services;

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
        builder.Services.AddMudServices(config =>
        {
            config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopEnd;
            config.SnackbarConfiguration.PreventDuplicates = false;
            config.SnackbarConfiguration.NewestOnTop = false;
            config.SnackbarConfiguration.ShowCloseIcon = true;
            config.SnackbarConfiguration.VisibleStateDuration = 10000;
            config.SnackbarConfiguration.HideTransitionDuration = 500;
            config.SnackbarConfiguration.ShowTransitionDuration = 500;
            config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
        });
        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddMatBlazor();
        builder.Services.AddMudServices();
        builder.Services.AddModalDialog();
        builder.Services.AddToastr(new ToastrOptions { closeButton = true, hideDuration = 3000 });

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		//builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
