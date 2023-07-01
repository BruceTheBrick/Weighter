using System.Diagnostics.CodeAnalysis;
using Weighter.Core.Models.Database;

namespace Weighter.Features.Registration.ViewModels
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
    }
}