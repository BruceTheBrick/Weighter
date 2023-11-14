using Weighter.Features;

namespace Weighter.Core;

public static class NavigationConstants
{
    public const string Dashboard = $"{nameof(TabbedPage)}?createTab={nameof(WorkoutPage)}&createTab={nameof(DashboardPage)}&createTab={nameof(NutritionPage)}&createTab={nameof(SettingsPage)}?selectedTab={nameof(DashboardPage)}";
}