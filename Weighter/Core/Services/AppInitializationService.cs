namespace Weighter.Core;

public class AppInitializationService : IAppInitializationService
{
    private readonly IApplication _application;
    private readonly IWeighterDatabase _weighterDatabase;
    private readonly IThemeService _themeService;
    public AppInitializationService(
        IApplication application,
        IWeighterDatabase weighterDatabase,
        IThemeService themeService)
    {
        _application = application;
        _weighterDatabase = weighterDatabase;
        _themeService = themeService;
    }

    public async Task Initialize()
    {
        _weighterDatabase.Initialize();
        _themeService.Theme = _application.UserAppTheme;
    }
}