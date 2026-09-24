namespace Weighter;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseNaveasy<InitPageViewModel>()
            .RegisterPagesForNavigation()
            .RegisterServices()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }

    private static MauiAppBuilder RegisterPagesForNavigation(this MauiAppBuilder builder)
    {
        builder.Services.AddTransientForNavigation<InitPage, InitPageViewModel>();
        builder.Services.AddTransientForNavigation<HomePage, HomePageViewModel>();
        return builder;
    }

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.RegisterPlatformServices();
        builder.Services.AddTransient<IBaseService, BaseService>();

        builder.Services.AddSingleton<StepCounterService>();
        builder.Services.AddTransient<IStepCounterService>(provider => provider.GetRequiredService<StepCounterService>());
        builder.Services.AddTransient<IInitializable>(provider => provider.GetRequiredService<StepCounterService>());
        return builder;
    }
}
