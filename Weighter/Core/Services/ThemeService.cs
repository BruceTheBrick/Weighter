using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Weighter.Core;

public class ThemeService : IThemeService, INotifyPropertyChanged
{
    private AppTheme _theme;
    public event PropertyChangedEventHandler PropertyChanged;
    public AppTheme Theme
    {
        get => _theme;
        set
        {
            if (_theme == value)
            {
                return;
            }

            _theme = value;
            OnPropertyChanged();
        }
    }

    public bool IsDarkMode => Theme == AppTheme.Dark;
    public bool IsLightMode => Theme == AppTheme.Light;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}