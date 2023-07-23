using CommunityToolkit.Mvvm.Input;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Features.Registration
{
    public class RegistrationWelcomePageViewModel : BasePageViewModel
    {
        public RegistrationWelcomePageViewModel(IBaseService baseService)
            : base(baseService)
        {
            ContinueCommand = new AsyncRelayCommand(Continue);
        }

        public IAsyncRelayCommand ContinueCommand { get; }

        private Task Continue()
        {
            return NavigationService.NavigateAsync(nameof(RegistrationUserDetailsPage));
        }
    }
}