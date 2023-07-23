using Weighter.Core.Services.Interfaces;
using Weighter.Features.Registration.ViewModels;

namespace Weighter.Features.Registration
{
    public class RegistrationThemeSelectionPageViewModel : BasePageViewModel
    {
        private readonly IThemeService _themeService;

        public RegistrationThemeSelectionPageViewModel(
            IThemeService themeService,
            IBaseService baseService)
            : base(baseService)
        {
            _themeService = themeService;
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
            RegistrationDetails =
                parameters.GetValue<RegistrationDetailsViewModel>(Core.Services.NavigationService.RegistrationDetails);
        }

        private void UpdateTheme(bool isDarkModeEnabled)
        {
            var theme = isDarkModeEnabled ? AppTheme.Dark : AppTheme.Light;
            _themeService.Theme = theme;
            RegistrationDetails.Settings.AppTheme = theme;
        }
    }
}