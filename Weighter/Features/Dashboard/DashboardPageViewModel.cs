using System.Windows.Input;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Weight_Tracking;

namespace Weighter.Features.Dashboard
{
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
}