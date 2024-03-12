namespace Weighter.Core;

public interface INavigationBarConfigurationService
{
    NavigationBarConfiguration GetConfiguration(NavigationBarActionType actionType);
}