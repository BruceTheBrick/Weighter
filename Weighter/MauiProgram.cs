using System.Diagnostics;
using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;

namespace Weighter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UsePrismApp<App>(PrismStartup.Configure)
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
}