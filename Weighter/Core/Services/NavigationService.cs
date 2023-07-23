using System.Diagnostics.CodeAnalysis;
using INavigationService = Weighter.Core.Services.Interfaces.INavigationService;

namespace Weighter.Core.Services
{
    [ExcludeFromCodeCoverage]
    public partial class NavigationService : INavigationService
    {
        private readonly Prism.Navigation.INavigationService _navigationService;
        public NavigationService(Prism.Navigation.INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public Task<INavigationResult> NavigateAsync(string uri)
        {
            return _navigationService.NavigateAsync(uri);
        }

        public Task<INavigationResult> NavigateAsync(string uri, INavigationParameters parameters)
        {
            return _navigationService.NavigateAsync(uri, parameters);
        }

        public Task<INavigationResult> GoBack()
        {
            return _navigationService.GoBackAsync();
        }

        public Task<INavigationResult> GoBack(INavigationParameters parameters)
        {
            return _navigationService.GoBackAsync(parameters);
        }
    }
}