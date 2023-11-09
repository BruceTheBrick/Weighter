using PropertyChanged;
using Weighter.Core.Services.Interfaces;
using INavigationService = Weighter.Core.Services.Interfaces.INavigationService;

namespace Weighter.Features;

[AddINotifyPropertyChangedInterface]
public class BasePageViewModel : INavigatedAware, IPageLifecycleAware
{
    public BasePageViewModel(IBaseService baseService)
    {
        NavigationService = baseService.NavigationService;
        LoggerService = baseService.LoggerService;
    }

    public INavigationService NavigationService { get; }
    public ILoggerService LoggerService { get; }

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

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {
        _ = OnNavigatedFromAsync(parameters);
    }

    public virtual Task OnNavigatedFromAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {
        _ = OnNavigatedToAsync(parameters);
    }

    public virtual Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }
}