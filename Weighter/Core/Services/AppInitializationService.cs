using System.Diagnostics.CodeAnalysis;

namespace Weighter.Core;

public class AppInitializationService : IAppInitializationService
{
    private readonly IWeighterDatabase _weighterDatabase;
    private readonly IThemeService _themeService;
    public AppInitializationService(
        IWeighterDatabase weighterDatabase,
        IThemeService themeService)
    {
        _weighterDatabase = weighterDatabase;
        _themeService = themeService;
    }

    public async Task Initialize()
    {
        _weighterDatabase.Initialize();
        SetupThemeService();
    }

    [ExcludeFromCodeCoverage]
    public virtual void SetupThemeService()
    {
        if (Application.Current != null)
        {
            _themeService.Theme = Application.Current.RequestedTheme;
        }
    }
}