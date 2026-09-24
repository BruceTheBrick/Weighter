namespace Weighter.Core.Services;

public class BaseService : IBaseService
{
    public INavigationService NavigationService { get; }

    public BaseService(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }
}
