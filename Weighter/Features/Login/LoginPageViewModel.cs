using CommunityToolkit.Mvvm.Input;

namespace Weighter.Features;

public partial class LoginPageViewModel : BasePageViewModel
{
    public LoginPageViewModel(IBaseService baseService)
        : base(baseService)
    {
    }

    [RelayCommand]
    private Task NavigateToDashboard()
    {
        return NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(DashboardPage)}");
    }
}