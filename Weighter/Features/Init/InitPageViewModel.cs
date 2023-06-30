using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;
using Weighter.Features.Registration;

namespace Weighter.Features.Init
{
    public class InitPageViewModel : BasePageViewModel
    {
        private readonly IUserDataLayer _userDataLayer;
        private readonly ITaskDelayService _taskDelayService;

        public InitPageViewModel(
            IUserDataLayer userDataLayer,
            ITaskDelayService taskDelayService,
            IBaseService baseService)
            : base(baseService)
        {
            _userDataLayer = userDataLayer;
            _taskDelayService = taskDelayService;
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            await base.OnNavigatedToAsync(parameters);
            await _taskDelayService.Delay(3000);
            if (_userDataLayer.AnyUsersRegistered())
            {
                await NavigateToDashboard();
                return;
            }

            await NavigateToRegistration();
        }

        private Task NavigateToDashboard()
        {
            return NavigationService.NavigateAsync(nameof(DashboardPage));
        }

        private Task NavigateToRegistration()
        {
            return NavigationService.NavigateAsync(nameof(WelcomePage));
        }
    }
}