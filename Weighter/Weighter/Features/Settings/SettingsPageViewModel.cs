using System.Windows.Input;
using Weighter.Core;

namespace Weighter.Features;

public class SettingsPageViewModel : BaseTabbedPageViewModel
{
    private readonly IThemeService _themeService;
    public SettingsPageViewModel(
        IThemeService themeService,
        IBaseService baseService)
        : base("Settings", "ic_settings", baseService)
    {
        _themeService = themeService;
        DarkModeToggledCommand = new Command(DarkModeToggled);
    }

    private void DarkModeToggled()
    {
        var currentTheme = _themeService.Theme;
        _themeService.Theme = currentTheme.AppTheme == AppTheme.Dark
            ? Theme.LightMode
            : Theme.DarkMode;
        IsDarkMode = _themeService.Theme.AppTheme == AppTheme.Dark;
    }

    public ICommand DarkModeToggledCommand { get; }
    public bool IsDarkMode { get; set; }
}