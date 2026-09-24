namespace Weighter;

public static class PlatformInitialization
{
    public static MauiAppBuilder RegisterPlatformServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<IStepCounterNativeService, StepCounterNativeService>();

        return builder;
    }
}
