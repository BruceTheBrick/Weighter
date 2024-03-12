using CommunityToolkit.Mvvm.Input;

namespace Weighter.Features;

public partial class RegistrationUserDetailsPageViewModel : BasePageViewModel
{
    public RegistrationUserDetailsPageViewModel(IBaseService baseService)
        : base(baseService)
    {
    }

    public RegistrationDetailsViewModel RegistrationDetails { get; set; } = new ();

    public override void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);
        if (parameters.TryGetValue<RegistrationDetailsViewModel>(Core.NavigationService.RegistrationDetails, out var details))
        {
            RegistrationDetails = details;
        }
    }

    [RelayCommand]
    private Task Next()
    {
        var parameters = new NavigationParameters { { Core.NavigationService.RegistrationDetails, RegistrationDetails }, };
        return NavigationService.NavigateAsync(nameof(RegistrationThemeSelectionPage), parameters);
    }
}