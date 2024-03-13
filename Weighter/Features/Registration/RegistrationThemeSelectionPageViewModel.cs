using CommunityToolkit.Mvvm.Input;

namespace Weighter.Features;

public partial class RegistrationThemeSelectionPageViewModel : BasePageViewModel
{
    private readonly IThemeService _themeService;
    private readonly IRegistrationDataLayer _registrationDataLayer;

    public RegistrationThemeSelectionPageViewModel(
        IThemeService themeService,
        IRegistrationDataLayer registrationDataLayer,
        IBaseService baseService)
        : base(baseService)
    {
        _themeService = themeService;
        _registrationDataLayer = registrationDataLayer;
    }

    public RegistrationDetailsViewModel RegistrationDetails { get; set; }
    public bool IsDarkModeEnabled
    {
        get => _themeService.IsDarkMode;
        set => UpdateTheme(value);
    }

    public override void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);
        RegistrationDetails = parameters.GetValue<RegistrationDetailsViewModel>(Core.NavigationService.RegistrationDetails);
    }

    private void UpdateTheme(bool isDarkModeEnabled)
    {
        var theme = isDarkModeEnabled ? AppTheme.Dark : AppTheme.Light;
        RegistrationDetails.Settings.AppTheme = theme;
        _themeService.Theme = theme;
    }

    [RelayCommand]
    private Task Continue()
    {
        var successfullyRegistered = _registrationDataLayer.Register(RegistrationDetails);
        if (successfullyRegistered)
        {
            return NavigationService.NavigateAsync($"/{Routes.NavigationPage}/{Routes.DashboardPage}");
        }

        return Task.CompletedTask;
    }

    [RelayCommand]
    private Task Back()
    {
        return NavigationService.GoBack();
    }
}