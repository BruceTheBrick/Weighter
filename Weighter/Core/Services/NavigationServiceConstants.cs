using Weighter.Features.Init;

namespace Weighter.Core.Services;

public partial class NavigationService
{
    public const string Startup = $"/{nameof(NavigationPage)}/{nameof(InitPage)}";

    public const string RegistrationDetails = nameof(RegistrationDetails);
}