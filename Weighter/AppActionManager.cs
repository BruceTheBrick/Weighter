using Weighter.Features.WeightTracking;

namespace Weighter
{
    public class AppActionManager
    {
        public static void ConfigureEssentials(IEssentialsBuilder essentialsBuilder)
        {
            CreateAppActions(essentialsBuilder);
            essentialsBuilder.OnAppAction(AppActionInvoked);
        }

        private static void CreateAppActions(IEssentialsBuilder essentialsBuilder)
        {
            if (!AppActions.Current.IsSupported)
            {
                return;
            }

            essentialsBuilder.AddAppAction("test_icon", "Testing actions", "This is my test action");
        }

        private static async void AppActionInvoked(AppAction appAction)
        {
            var page = string.Empty;
            if (appAction.Id == "test_icon")
            {
                page = $"/{nameof(NavigationPage)}/{nameof(WeightSummaryPage)}";
            }
        }
    }
}