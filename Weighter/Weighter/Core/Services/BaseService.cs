namespace Weighter.Core;

public class BaseService : IBaseService
{
    public BaseService(
        INavigationService navigationService,
        IAccessibilityService accessibilityService)
    {
        NavigationService = navigationService;
        AccessibilityService = accessibilityService;
    }

    public INavigationService NavigationService { get; }
    public IAccessibilityService AccessibilityService { get; }
}