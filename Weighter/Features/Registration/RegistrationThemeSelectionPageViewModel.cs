using CommunityToolkit.Mvvm.Input;
using Weighter.Core.DataLayers.Interfaces;
using Weighter.Core.Services.Interfaces;
using Weighter.Features.Dashboard;
using Weighter.Features.Registration._ViewModels;

namespace Weighter.Features.Registration;

public class RegistrationThemeSelectionPageViewModel : BasePageViewModel
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
        ContinueCommand = new AsyncRelayCommand(Continue);
    }

    public RegistrationDetailsViewModel RegistrationDetails { get; set; }
    public IAsyncRelayCommand ContinueCommand { get; }
    public bool IsDarkModeEnabled
    {
        get => _themeService.IsDarkMode;
        set => UpdateTheme(value);
    }

    public override void OnNavigatedTo(INavigationParameters parameters)
    {
        base.OnNavigatedTo(parameters);
        RegistrationDetails =
            parameters.GetValue<RegistrationDetailsViewModel>(Core.Services.NavigationService.RegistrationDetails);
    }

    private void UpdateTheme(bool isDarkModeEnabled)
    {
        var theme = isDarkModeEnabled ? AppTheme.Dark : AppTheme.Light;
        _themeService.Theme = theme;
        RegistrationDetails.Settings.AppTheme = theme;
    }

    private Task Continue()
    {
        var successfullyRegistered = _registrationDataLayer.Register(RegistrationDetails);
        if (successfullyRegistered)
        {
            return NavigationService.NavigateAsync($"/{nameof(NavigationPage)}/{nameof(DashboardPage)}");
        }

        return Task.CompletedTask;
    }
}