using System.Diagnostics.CodeAnalysis;
using Weighter.Core.Models.Database;

namespace Weighter.Features.Registration._ViewModels
{
    [ExcludeFromCodeCoverage]
    public class RegistrationDetailsViewModel
    {
        public RegistrationDetailsViewModel()
        {
        }

        public RegistrationDetailsViewModel(UserModel user, UserSettingsModel userSettingsModel)
        {
            User = user;
            Settings = userSettingsModel;
        }

        public UserModel User { get; } = new ();
        public UserSettingsModel Settings { get; } = new ();

        public void LinkSettingsToUser()
        {
            Settings.UserId = User.Id;
        }
    }
}