using System.Diagnostics;
using CommunityToolkit.Maui;
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
                .UseMauiCommunityToolkit()
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
    }
}