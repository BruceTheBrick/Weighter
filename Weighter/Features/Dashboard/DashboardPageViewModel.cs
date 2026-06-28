using System.Windows.Input;

namespace Weighter.Features;

public class DashboardPageViewModel : BasePageViewModel
{
    public DashboardPageViewModel(IBaseService baseService) 
        : base(baseService)
    {
        NavigateToWeightSummaryPageCommand = new DelegateCommand(NavigateToWeightSummaryPage);
    }

    private async void NavigateToWeightSummaryPage()
    {
        await NavigationService.NavigateAsync(nameof(WeightSummaryPage));
    }

    public ICommand NavigateToWeightSummaryPageCommand { get; }
}