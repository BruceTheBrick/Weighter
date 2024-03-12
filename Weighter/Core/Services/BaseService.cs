using System.Diagnostics.CodeAnalysis;

namespace Weighter.Core;

[ExcludeFromCodeCoverage]
public class BaseService : IBaseService
{
    public BaseService(
        INavigationService navigationService,
        ILoggerService loggerService)
    {
        NavigationService = navigationService;
        LoggerService = loggerService;
    }

    public INavigationService NavigationService { get; }
    public ILoggerService LoggerService { get; }
}