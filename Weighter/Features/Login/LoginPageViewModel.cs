using CommunityToolkit.Mvvm.Input;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;

namespace Weighter.Features.Login
{
    public class LoginPageViewModel : BasePageViewModel
    {
        public LoginPageViewModel(IBaseService baseService)
            : base(baseService)
        {
            NavigateToDashboardCommand = new AsyncRelayCommand(NavigateToDashboard);
        }

        public IAsyncRelayCommand NavigateToDashboardCommand { get; }

        private Task NavigateToDashboard()
        {
            return NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(DashboardPage)}");
        }
    }
}