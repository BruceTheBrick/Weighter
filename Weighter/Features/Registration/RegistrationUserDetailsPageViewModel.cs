using CommunityToolkit.Mvvm.Input;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration.ViewModels;

namespace Weighter.Features.Registration
{
    public class RegistrationUserDetailsPageViewModel : BasePageViewModel
    {
        public RegistrationUserDetailsPageViewModel(IBaseService baseService)
            : base(baseService)
        {
            NextCommand = new AsyncRelayCommand(Next);
        }

        public IAsyncRelayCommand NextCommand { get; }
        public RegistrationDetailsViewModel RegistrationDetails { get; set; } = new ();

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.TryGetValue<RegistrationDetailsViewModel>(Core.Services.NavigationService.RegistrationDetails, out var details))
            {
                RegistrationDetails = details;
            }
        }

        private Task Next()
        {
            var parameters = new NavigationParameters { { Core.Services.NavigationService.RegistrationDetails, RegistrationDetails }, };
            return NavigationService.NavigateAsync(nameof(RegistrationThemeSelectionPage), parameters);
        }
    }
}