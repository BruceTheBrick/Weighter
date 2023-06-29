using CommunityToolkit.Mvvm.Input;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Weight_Tracking;

namespace Weighter.Features.Dashboard
{
    public class DashboardPageViewModel : BasePageViewModel
    {
        public DashboardPageViewModel(IBaseService baseService)
            : base(baseService)
        {
            NavigateToWeightSummaryPageCommand = new AsyncRelayCommand(NavigateToWeightSummaryPage);
        }

        public IAsyncRelayCommand NavigateToWeightSummaryPageCommand { get; }

        private Task NavigateToWeightSummaryPage()
        {
            return NavigationService.NavigateAsync(nameof(WeightSummaryPage));
        }
    }
}