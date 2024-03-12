using System.Diagnostics;
using INavigationService = Weighter.Core.INavigationService;
using RegistrationUserDetailsPageViewModel = Weighter.Features.RegistrationUserDetailsPageViewModel;
using RegistrationWelcomePageViewModel = Weighter.Features.RegistrationWelcomePageViewModel;

namespace Weighter;

public static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes);
        builder.OnAppStart(NavigationService.Startup);
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        RegisterServices(containerRegistry);
        RegisterPagesForNavigation(containerRegistry);
    }

    private static void RegisterServices(IContainerRegistry containerRegistry)
    {
        RegisterDataLayers(containerRegistry);
        RegisterDatabaseServices(containerRegistry);
        RegisterSingletons(containerRegistry);

        RegisterIosPlatformServices(containerRegistry);
        RegisterAndroidPlatformServices(containerRegistry);

        containerRegistry.Register<IBaseService, BaseService>();
        containerRegistry.Register<INavigationService, NavigationService>();
        containerRegistry.Register<ISqlClientService, SqlClientService>();
        containerRegistry.Register<ITaskDelayService, TaskDelayService>();
        containerRegistry.Register<IDeviceInfo, DeviceInfoService>();
        containerRegistry.Register<ILoggerService, LoggerService>();
        containerRegistry.Register<IAppInitializationService, AppInitializationService>();
    }

    private static void RegisterDataLayers(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<IUserDataLayer, UserDataLayer>();
        containerRegistry.Register<IRegistrationDataLayer, RegistrationDataLayer>();
    }

    private static void RegisterDatabaseServices(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<IWeighterDatabase, WeighterDatabase>();
    }

    private static void RegisterSingletons(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IThemeService, ThemeService>();
    }

    private static void RegisterPagesForNavigation(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<NavigationPage>();
        containerRegistry.RegisterForNavigation<InitPage, InitPageViewModel>();
        containerRegistry.RegisterForNavigation<RegistrationWelcomePage, RegistrationWelcomePageViewModel>();
        containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
        containerRegistry.RegisterForNavigation<WeightSummaryPage, WeightSummaryPageViewModel>();
        containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
        containerRegistry.RegisterForNavigation<RegistrationUserDetailsPage, RegistrationUserDetailsPageViewModel>();
        containerRegistry.RegisterForNavigation<RegistrationThemeSelectionPage, RegistrationThemeSelectionPageViewModel>();
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