using System.Diagnostics;
using Weighter.Core.Services;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;
using Weighter.Features.Init;
using Weighter.Features.Registration;
using Weighter.Features.Weight_Tracking;
using INavigationService = Weighter.Core.Services.Interfaces.INavigationService;

namespace Weighter
{
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
            containerRegistry.Register<IBaseService, BaseService>();
            containerRegistry.Register<INavigationService, NavigationService>();
            containerRegistry.Register<IThemeService, ThemeService>();

            RegisterIosPlatformServices(containerRegistry);
            RegisterAndroidPlatformServices(containerRegistry);
        }

        private static void RegisterPagesForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<InitPage, InitPageViewModel>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();
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
}