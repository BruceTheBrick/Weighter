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

        private Task Continue()
        {
            return NavigationService.NavigateAsync(nameof(UserDetailsRegistrationPage));
        }
    }
}