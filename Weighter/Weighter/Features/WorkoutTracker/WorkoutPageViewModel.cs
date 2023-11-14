using Weighter.Core;

namespace Weighter.Features;

public class WorkoutPageViewModel : BaseTabbedPageViewModel
{
    private readonly IFeatureToggleService _featureToggleService;
    public WorkoutPageViewModel(
        IFeatureToggleService featureToggleService,
        IBaseService baseService)
        : base("Workouts", "ic_dumbbell", baseService)
    {
        _featureToggleService = featureToggleService;
    }
        
    public bool IsToggleWorking { get; set; }

    public override void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);
        IsToggleWorking = _featureToggleService.IsEnabled(FeatureToggleConstants.Temp);
    }
}