using Weighter.Core;

namespace Weighter.Features;

public class DashboardPageViewModel : BaseTabbedPageViewModel
{
    public DashboardPageViewModel(IBaseService baseService)
        : base("Dashboard", "ic_home", baseService)
    {
    }
}