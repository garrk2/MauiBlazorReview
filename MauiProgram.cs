
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.AspNetCore.Components.WebView.Maui;
using DoublesMatch2.Services;

namespace DoublesMatch2;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
            });

        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif
        builder.Services.AddSingleton<PlayerService>();

        return builder.Build();
    }
}
