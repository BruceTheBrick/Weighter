using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration;

namespace Weighter.Features.Init
{
    public class InitPageViewModel : BasePageViewModel
    {
        private readonly ITaskDelayService _taskDelayService;

        public InitPageViewModel(
            ITaskDelayService taskDelayService,
            IBaseService baseService)
            : base(baseService)
        {
            _taskDelayService = taskDelayService;
        }

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            await base.OnNavigatedToAsync(parameters);
            await _taskDelayService.Delay(3000);
            await NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(WelcomePage)}");
        }
    }
}