namespace Weighter.Core;

public class NavigationService : INavigationService
{
    private readonly Prism.Navigation.INavigationService _navigationService;
    public NavigationService(Prism.Navigation.INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    public Task<INavigationResult> NavigateAsync(string url)
    {
        return _navigationService.NavigateAsync(url);
    }

    public Task<INavigationResult> NavigateAsync(string url, INavigationParameters parameters)
    {
        return _navigationService.NavigateAsync(url, parameters);
    }
}