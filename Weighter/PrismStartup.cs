using System.Diagnostics;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter;

public static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes);
        builder.CreateWindow(NavigationService.Startup);
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        RegisterServices(containerRegistry);
        RegisterPagesForNavigation(containerRegistry);
    }

    private static void RegisterServices(IContainerRegistry containerRegistry)
    {
        RegistrationManager.RegisterServices(containerRegistry);

        RegisterIosPlatformServices(containerRegistry);
        RegisterAndroidPlatformServices(containerRegistry);
    }

    private static void RegisterPagesForNavigation(IContainerRegistry containerRegistry)
    {
        RegistrationManager.RegisterPagesForNavigation(containerRegistry);
        containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
        containerRegistry.RegisterForNavigation<WeightSummaryPage, WeightSummaryPageViewModel>();
    }

    [Conditional("IOS")]
    private static void RegisterIosPlatformServices(IContainerRegistry containerRegistry)
    {

    }

    [Conditional("ANDROID")]
    private static void RegisterAndroidPlatformServices(IContainerRegistry containerRegistry)
    {

    }
}