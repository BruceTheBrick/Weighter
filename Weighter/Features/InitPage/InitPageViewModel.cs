namespace Weighter.Features;

public class InitPageViewModel : BasePageViewModel
{
    public InitPageViewModel(INavigationService navigationService)
        : base(navigationService)
    {
    }

    public override async Task OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        await NavigationService.NavigateAbsoluteAsync<HomePageViewModel>();
    }
}
