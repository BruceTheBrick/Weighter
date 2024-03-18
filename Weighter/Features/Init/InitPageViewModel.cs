namespace Weighter.Features;

public class InitPageViewModel : BasePageViewModel
{
    private readonly IAppInitializationService _appInitializationService;
    private readonly IUserDataLayer _userDataLayer;
    private readonly IAlertService _alertService;

    public InitPageViewModel(
        IAppInitializationService appInitializationService,
        IUserDataLayer userDataLayer,
        IAlertService alertService,
        IBaseService baseService)
        : base(baseService)
    {
        _appInitializationService = appInitializationService;
        _userDataLayer = userDataLayer;
        _alertService = alertService;
    }

    public bool IsBusy { get; set; }

    public override async Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        try
        {
            IsBusy = true;
            await base.OnNavigatedToAsync(parameters);
            await _appInitializationService.Initialize();
            await StartApp();
        }
        catch (Exception e)
        {
            IsBusy = false;
            await _alertService.ShowSnackbar("Something has gone wrong. Please try again later.");
            LoggerService.LogException(e);
        }
    }

    private Task StartApp()
    {
        var destinationPage = _userDataLayer.AnyUsersRegistered() ? Routes.LoginPage : Routes.RegistrationWelcomePage;
        return NavigationService.Navigate($"/{Routes.NavigationPage}/{destinationPage}");
    }
}