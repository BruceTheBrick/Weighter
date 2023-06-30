using System.Diagnostics;
using Weighter.Core.DataLayers;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Services;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;
using Weighter.Features.Init;
using Weighter.Features.Registration;
using Weighter.Features.WeightTracking;
using INavigationService = Weighter.Core.Services.Interfaces.INavigationService;

namespace Weighter
{
    public static class PrismStartup
    {
        public static void Configure(PrismAppBuilder builder)
        {
            builder.RegisterTypes(RegisterTypes);
            builder.OnAppStart(nav =>
            {
                var t = nav.NavigateAsync(nameof(InitPage));
            });
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

            RegisterIosPlatformServices(containerRegistry);
            RegisterAndroidPlatformServices(containerRegistry);

            containerRegistry.Register<IBaseService, BaseService>();
            containerRegistry.Register<INavigationService, NavigationService>();
            containerRegistry.Register<IThemeService, ThemeService>();
            containerRegistry.Register<ISqlClientService, SqlClientService>();
            containerRegistry.Register<ITaskDelayService, TaskDelayService>();
            containerRegistry.Register<IDeviceInfo, DeviceInfoService>();
        }

        private static void RegisterDataLayers(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IUserDataLayer, UserDataLayer>();
            containerRegistry.Register<IWeighterDataLayer, WeighterDataLayer>();
        }

        private static void RegisterDatabaseServices(IContainerRegistry containerRegistry)
        {
        }

        private static void RegisterPagesForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
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