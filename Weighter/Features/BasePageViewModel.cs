using AsyncAwaitBestPractices;
using PropertyChanged;
using INavigationService = Weighter.Core.INavigationService;

namespace Weighter.Features;

[AddINotifyPropertyChangedInterface]
public class BasePageViewModel : INavigatedAware, IPageLifecycleAware, IInitialize, IInitializeAsync
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
        OnAppearingAsync().SafeFireAndForget();
    }

    public virtual Task OnAppearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual void OnDisappearing()
    {
        OnDisappearingAsync().SafeFireAndForget();
    }

    public virtual Task OnDisappearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedFrom(INavigationParameters parameters)
    {
        OnNavigatedFromAsync(parameters).SafeFireAndForget();
    }

    public virtual Task OnNavigatedFromAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedTo(INavigationParameters parameters)
    {
        OnNavigatedToAsync(parameters).SafeFireAndForget();
    }

    public virtual Task OnNavigatedToAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }

    public void Initialize(INavigationParameters parameters)
    {
    }

    public Task InitializeAsync(INavigationParameters parameters)
    {
        return Task.CompletedTask;
    }
}