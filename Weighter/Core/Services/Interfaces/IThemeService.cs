using System.ComponentModel;

namespace Weighter.Core.Services.Interfaces
{
    public interface IThemeService
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public AppTheme Theme { get; set; }
    }
}
