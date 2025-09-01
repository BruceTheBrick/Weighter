using System.Diagnostics.CodeAnalysis;

namespace Weighter.Features;

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

    public UserModel User { get; } = new();
    public UserSettingsModel Settings { get; } = new();

    public void LinkSettingsToUser()
    {
        Settings.UserId = User.Id;
    }
}