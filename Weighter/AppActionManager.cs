using Weighter.Features.Registration;

namespace Weighter
{
    public class AppActionManager
    {
        public static void ConfigureEssentials(IEssentialsBuilder essentialsBuilder)
        {
            essentialsBuilder.AddAppAction("test_icon", "Testing actions", "This is my test action");
            essentialsBuilder.OnAppAction(AppActionInvoked);
        }

        private static async void AppActionInvoked(AppAction appAction)
        {
            var page = new Page();
            if (appAction.Id == "test_icon")
            {
                page = new RegistrationUserDetailsPage();
            }

            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}