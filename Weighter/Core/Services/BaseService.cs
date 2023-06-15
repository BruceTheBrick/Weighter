using System.Diagnostics.CodeAnalysis;
using Weighter.Core.Services.Interfaces;
using INavigationService = Weighter.Core.Services.Interfaces.INavigationService;

namespace Weighter.Core.Services
{
    [ExcludeFromCodeCoverage]
    public class BaseService : IBaseService
    {
        public BaseService(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
        
        public INavigationService NavigationService { get; }
    }
}