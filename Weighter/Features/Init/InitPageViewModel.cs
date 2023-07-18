using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Login;
using Weighter.Features.Registration;

namespace Weighter.Features.Init
{
    public class InitPageViewModel : BasePageViewModel
    {
        private readonly IAppInitializationService _appInitializationService;
        private readonly IUserDataLayer _userDataLayer;
        private readonly ITaskDelayService _taskDelayService;

        public InitPageViewModel(
            IAppInitializationService appInitializationService,
            IUserDataLayer userDataLayer,
            ITaskDelayService taskDelayService,
            IBaseService baseService)
            : base(baseService)
        {
            _appInitializationService = appInitializationService;
            _userDataLayer = userDataLayer;
            _taskDelayService = taskDelayService;
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            try
            {
                await base.OnNavigatedToAsync(parameters);
                await _appInitializationService.Initialize();
                await StartApp();
            }
            catch (Exception e)
            {
                LoggerService.LogException(e);
            }
        }

        private async Task StartApp()
        {
            await _taskDelayService.Delay(3000);
            if (_userDataLayer.AnyUsersRegistered())
            {
                await NavigateToLoginPage();
                return;
            }

            await NavigateToRegistration();
        }

        private Task NavigateToLoginPage()
        {
            return NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(LoginPage)}");
        }

        private Task NavigateToRegistration()
        {
            return NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(RegistrationWelcomePage)}");
        }
    }
}