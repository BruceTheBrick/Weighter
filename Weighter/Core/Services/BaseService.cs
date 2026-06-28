using System.Diagnostics.CodeAnalysis;

namespace Weighter.Core;

[ExcludeFromCodeCoverage]
public class BaseService : IBaseService
{
    public BaseService(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }
        
    public INavigationService NavigationService { get; }
}