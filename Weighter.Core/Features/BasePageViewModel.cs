using IInitialize = Naveasy.IInitialize;
using IInitializeAsync = Naveasy.IInitializeAsync;

namespace Weighter.Core.Features;

public abstract partial class BasePageViewModel : IInitialize, IInitializeAsync, INavigatedAware, IPageLifecycleAware
{
    public BasePageViewModel(IBaseService baseService)
    {
        NavigationService = baseService.NavigationService;
    }

    public INavigationService NavigationService { get; private set; }

    public virtual void OnInitialize(INavigationParameters parameters)
    {
    }

    public virtual Task OnInitializeAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }

    public virtual void OnAppearing()
    {
        _ = OnAppearingAsync();
    }

    public virtual Task OnAppearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual void OnDisappearing()
    {
        _ = OnDisappearingAsync();
    }

    public virtual Task OnDisappearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedTo(INavigationParameters navigationParameters)
    {
        _ = OnNavigatedToAsync(navigationParameters);
    }

    public virtual Task OnNavigatedToAsync(INavigationParameters navigationParameters)
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedFrom(INavigationParameters navigationParameters)
    {
        _ = OnNavigatedFromAsync(navigationParameters);
    }

    public virtual Task OnNavigatedFromAsync(INavigationParameters navigationParameters)
    {
        return Task.CompletedTask;
    }
}
