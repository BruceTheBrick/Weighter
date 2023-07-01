using CommunityToolkit.Mvvm.Input;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Features.Registration
{
    public class WelcomePageViewModel : BasePageViewModel
    {
        public WelcomePageViewModel(IBaseService baseService)
            : base(baseService)
        {
            ContinueCommand = new AsyncRelayCommand(Continue);
        }

        public IAsyncRelayCommand ContinueCommand { get; }

        private async Task Continue()
        {
            var t = NavigationService.NavigateAsync(nameof(UserDetailsRegistrationPage));
        }
    }
}