using Weighter.Core;
using Weighter.Features;
using IDeviceInfo = Weighter.Core.IDeviceInfo;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder
            .RegisterTypes(RegisterTypes)
            // .RegisterTypes(PlatformInitializer.RegisterTypes)
            .OnAppStart(nameof(SplashPage));
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        RegisterNavigation(containerRegistry);
        RegisterServices(containerRegistry);
    }

    private static void RegisterNavigation(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<SplashPage, SplashPageViewModel>();
        containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
        containerRegistry.RegisterForNavigation<WorkoutPage, WorkoutPageViewModel>();
        containerRegistry.RegisterForNavigation<NutritionPage, NutritionPageViewModel>();
        containerRegistry.RegisterForNavigation<SettingsPage, SettingsPageViewModel>();
    }

    private static void RegisterServices(IContainerRegistry containerRegistry)
    {
        RegisterSingletonServices(containerRegistry);
        containerRegistry.Register<IBaseService, BaseService>();
        containerRegistry.Register<INavigationService, NavigationService>();
        containerRegistry.Register<IAccessibilityService, AccessibilityService>();
        containerRegistry.Register<IDeviceInfo, Core.DeviceInfo>();
        containerRegistry.Register<ITaskDelay, TaskDelay>();
        containerRegistry.Register<IFeatureToggleService, FeatureToggleService>();
        containerRegistry.Register<IAnalyticsService, AnalyticsService>();
        containerRegistry.Register<IFirebaseInitService, FirebaseInitService>();
    }

    private static void RegisterSingletonServices(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterSingleton<IThemeService, ThemeService>();
    }
}