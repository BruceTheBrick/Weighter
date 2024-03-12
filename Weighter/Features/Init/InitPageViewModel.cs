namespace Weighter.Features;

public class InitPageViewModel : BasePageViewModel
{
    private readonly IAppInitializationService _appInitializationService;
    private readonly IUserDataLayer _userDataLayer;

    public InitPageViewModel(
        IAppInitializationService appInitializationService,
        IUserDataLayer userDataLayer,
        IBaseService baseService)
        : base(baseService)
    {
        _appInitializationService = appInitializationService;
        _userDataLayer = userDataLayer;
    }

    public override async Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        try
        {
            await base.OnNavigatedToAsync(parameters);
            await _appInitializationService.Initialize();
            await StartApp();
        }
        catch (Exception e)
        {
            LoggerService.LogException(e);
        }
    }

    private Task StartApp()
    {
        var destinationPage = _userDataLayer.AnyUsersRegistered() ? Routes.LoginPage : Routes.RegistrationWelcomePage;
        return NavigationService.NavigateAsync($"/{Routes.NavigationPage}/{destinationPage}");
    }
}