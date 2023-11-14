using CommunityToolkit.Maui;
using Plugin.Firebase.Auth;

namespace Weighter;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UsePrismApp<App>(PrismStartup.Configure)
            .UseMauiCommunityToolkit()
            .RegisterFirebase()
            .ConfigureFonts(ConfigureFonts);

        return builder.Build();
    }

    private static MauiAppBuilder RegisterFirebase(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton(_ => CrossFirebaseAuth.Current);
        return builder;
    }

    private static void ConfigureFonts(IFontCollection fontCollection)
    {
        fontCollection.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        fontCollection.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
    }
}