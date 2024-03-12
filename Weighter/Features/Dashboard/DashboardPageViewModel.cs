using CommunityToolkit.Mvvm.Input;

namespace Weighter.Features;

public partial class DashboardPageViewModel : BasePageViewModel
{
    public DashboardPageViewModel(IBaseService baseService)
        : base(baseService)
    {
    }

    [RelayCommand]
    private Task NavigateToWeightSummaryPage()
    {
        return NavigationService.NavigateAsync(nameof(WeightSummaryPage));
    }
}