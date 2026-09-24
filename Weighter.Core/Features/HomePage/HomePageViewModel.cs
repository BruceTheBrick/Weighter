namespace Weighter.Core.Features;

public class HomePageViewModel : BasePageViewModel
{
    private readonly IStepCounterService _stepCounterService;

    public HomePageViewModel(IBaseService baseService,
        IStepCounterService stepCounterService) :
        base(baseService)
    {
        _stepCounterService = stepCounterService;
    }

    public override void OnNavigatedTo(INavigationParameters navigationParameters)
    {
        base.OnNavigatedTo(navigationParameters);
    }
}
