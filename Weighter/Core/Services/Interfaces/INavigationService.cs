namespace Weighter.Core;

public interface INavigationService
{
    Task<INavigationResult> Navigate(string uri);
    Task<INavigationResult> Navigate(string uri, INavigationParameters parameters);

    Task<INavigationResult> GoBack();
    Task<INavigationResult> GoBack(INavigationParameters parameters);
}