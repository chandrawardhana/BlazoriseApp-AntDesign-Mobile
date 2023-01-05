using Microsoft.AspNetCore.Components.WebView.Maui;



using Blazorise;
using Blazorise.AntDesign;
using Blazorise.Icons.FontAwesome;

namespace BlazoriseApp;

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

		builder.Services.AddMauiBlazorWebView();

		builder.Services
		.AddBlazorise( options =>
		{
			options.Immediate = true;
		} )
		.AddAntDesignProviders()
		.AddFontAwesomeIcons();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		
#endif

		

		return builder.Build();
	}
}

