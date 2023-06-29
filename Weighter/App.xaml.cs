using System.ComponentModel;
using Weighter.Core;
using Weighter.Core.Services.Interfaces;

namespace Weighter
{
    public partial class App
    {
        private readonly IThemeService _themeService;
        public App(IThemeService themeService)
        {
            InitializeComponent();

            _themeService = themeService;
            _themeService.PropertyChanged += OnThemeChanged;
        }

        private void OnThemeChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_themeService.Theme))
            {
                UpdateTheme();
            }
        }

        private void UpdateTheme()
        {
            UserAppTheme = _themeService.Theme;
        }
    }
}