using System.ComponentModel;
using Weighter.Core;
using Weighter.Features;

namespace Weighter;

public partial class App
{
    private readonly IThemeService _themeService;
    public App(IThemeService themeService)
    {
        _themeService = themeService;
        InitializeComponent();

        _themeService.PropertyChanged += OnThemeChanged;
    }

    protected override async void OnInitialized()
    {
        base.OnInitialized();
        await NavigationService.NavigateAsync($"/{nameof(SplashPage)}");
    }

    private void OnThemeChanged(object sender, PropertyChangedEventArgs eventArgs)
    {
        if (eventArgs.PropertyName == nameof(_themeService.Theme))
        {
            UpdateTheme();
        }
    }

    private void UpdateTheme()
    {
        UserAppTheme = _themeService.Theme.AppTheme;
    }
}