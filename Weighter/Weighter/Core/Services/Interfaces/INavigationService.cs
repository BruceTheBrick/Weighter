namespace Weighter.Core;

public interface INavigationService
{
    Task<INavigationResult> NavigateAsync(string url);
    Task<INavigationResult> NavigateAsync(string url, INavigationParameters parameters);
}