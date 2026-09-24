using IInitialize = Weighter.Core.Services.IInitialize;
using IInitializeAsync = Weighter.Core.Services.IInitializeAsync;

namespace Weighter.Core.Features;

public class InitPageViewModel : BasePageViewModel
{
    private readonly IEnumerable<IInitializable> _initializables;
    public InitPageViewModel(IBaseService baseService, IEnumerable<IInitializable> initializables)
        : base(baseService)
    {
        _initializables = initializables;
    }

    public override async Task OnAppearingAsync()
    {
        var initTasks = new List<Task>();
        foreach (var initializable in _initializables)
        {
            if (initializable is IInitialize initializer)
            {
                initializer.Initialize();
            }

            if (initializable is IInitializeAsync asyncInitializer)
            {
                initTasks.Add(asyncInitializer.InitializeAsync());
            }
        }

        await Task.WhenAll(initTasks);
        await NavigationService.NavigateAbsoluteAsync<HomePageViewModel>();
    }
}
