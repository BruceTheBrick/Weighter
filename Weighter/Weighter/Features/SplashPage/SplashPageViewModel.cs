using Weighter.Core;

namespace Weighter.Features;

public class SplashPageViewModel : BasePageViewModel
{
    private readonly ITaskDelay _taskDelay;
    private readonly IFirebaseInitService _firebaseInitService;
    public SplashPageViewModel(
        IFirebaseInitService firebaseInitService,
        ITaskDelay taskDelay,
        IBaseService baseService)
        : base(baseService)
    {
        _firebaseInitService = firebaseInitService;
        _taskDelay = taskDelay;
    }

    public override async Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        await base.OnNavigatedToAsync(parameters);
        await _firebaseInitService.Initialize();
        await NavigationService.NavigateAsync(NavigationConstants.Dashboard);
    }
}