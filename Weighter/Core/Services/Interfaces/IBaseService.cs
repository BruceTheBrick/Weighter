namespace Weighter.Core;

public interface IBaseService
{
    public INavigationService NavigationService { get; }
    public ILoggerService LoggerService { get; }
}