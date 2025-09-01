using System.Diagnostics;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace Weighter;

[AutoRoutes("Page")]
[ExtraRoute(nameof(NavigationPage), typeof(NavigationPage))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        if (!OperatingSystem.IsAndroidVersionAtLeast(21))
        {
            throw new Exception("Android API level must be 21 or higher");
        }

        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UsePrism(PrismStartup.Configure)
            .UseMauiCommunityToolkit(ConfigureCommunityToolkit)
            .UseMauiCommunityToolkitMarkup()
            .ConfigureFonts(ConfigureFonts);
        EnableDebug(builder);
        return builder.Build();
    }

    private static void ConfigureFonts(IFontCollection fonts)
    {
        fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    }

    [Conditional("DEBUG")]
    private static void EnableDebug(MauiAppBuilder builder)
    {
        builder.Logging.AddDebug();
    }

    private static void ConfigureCommunityToolkit(Options options)
    {
        options.SetShouldSuppressExceptionsInConverters(true);
    }
}