using PropertyChanged;
using Weighter.Core;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter.Features;

[AddINotifyPropertyChangedInterface]
public class BasePageViewModel : INavigationAware, IInitialize, IInitializeAsync, IPageLifecycleAware
{
    public BasePageViewModel(IBaseService baseService)
    {
        NavigationService = baseService.NavigationService;
        AccessibilityService = baseService.AccessibilityService;
    }

    public virtual void Initialize(INavigationParameters parameters)
    {
    }

    public virtual Task InitializeAsync(INavigationParameters parameters)
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

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {
        _ = OnNavigatedFromAsync(parameters);
    }

    public virtual Task OnNavigatedFromAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }

    public void OnAppearing()
    {
        _ = OnAppearingAsync();
    }

    public void OnDisappearing()
    {
        _ = OnDisappearingAsync();
    }

    public virtual Task OnAppearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual Task OnDisappearingAsync()
    {
        return Task.CompletedTask;
    }
        
    public INavigationService NavigationService { get; }
    public IAccessibilityService AccessibilityService { get; }
}