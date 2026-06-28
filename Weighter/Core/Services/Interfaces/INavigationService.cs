namespace Weighter.Core;

public interface INavigationService
{
    Task<INavigationResult> NavigateAsync(string uri);
    Task<INavigationResult> NavigateAsync(string uri, INavigationParameters parameters);

    Task<INavigationResult> GoBack();
    Task<INavigationResult> GoBack(INavigationParameters parameters);
}