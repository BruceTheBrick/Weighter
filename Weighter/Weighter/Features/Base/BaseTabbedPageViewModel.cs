using Weighter.Core;

namespace Weighter.Features;

public class BaseTabbedPageViewModel : BasePageViewModel, ITabPage

{
    public BaseTabbedPageViewModel(
        string tabTitle,
        string tabIcon,
        IBaseService baseService)
        : base(baseService)
    {
        TabTitle = tabTitle;
        TabIcon = tabIcon;
    }

    public string TabTitle { get; }
    public string TabIcon { get; }
}