using CommunityToolkit.Mvvm.Input;

namespace Weighter.Features;

public partial class RegistrationWelcomePageViewModel : BasePageViewModel
{
    public RegistrationWelcomePageViewModel(IBaseService baseService)
        : base(baseService)
    {
    }

    [RelayCommand]
    private Task Continue()
    {
        return NavigationService.Navigate(Routes.RegistrationUserDetailsPage);
    }
}