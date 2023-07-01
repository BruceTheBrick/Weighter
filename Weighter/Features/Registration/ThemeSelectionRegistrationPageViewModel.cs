using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration.ViewModels;

namespace Weighter.Features.Registration
{
    public class ThemeSelectionRegistrationPageViewModel : BasePageViewModel
    {
        private readonly IThemeService _themeService;
        private bool _isDarkModeEnabled;

        public ThemeSelectionRegistrationPageViewModel(
            IThemeService themeService,
            IBaseService baseService)
            : base(baseService)
        {
            _themeService = themeService;
        }

        public RegistrationDetailsViewModel RegistrationDetails { get; set; }
        public bool IsDarkModeEnabled
        {
            get => _isDarkModeEnabled;
            set
            {
                _isDarkModeEnabled = value;
                UpdateTheme();
            }
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            if (parameters.TryGetValue<RegistrationDetailsViewModel>(
                    Core.Services.NavigationService.RegistrationDetails, out var details))
            {
                RegistrationDetails = details;
            }
        }

        private void UpdateTheme()
        {
            var theme = IsDarkModeEnabled ? AppTheme.Dark : AppTheme.Light;
            _themeService.Theme = theme;
            RegistrationDetails.Settings.AppTheme = theme;
        }
    }
}