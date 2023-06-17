using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Weighter.Core
{
    public class ThemeService : IThemeService, INotifyPropertyChanged
    {
        private Theme _theme;

        public ThemeService()
        {
            Theme = Theme.System;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public Theme Theme
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

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
