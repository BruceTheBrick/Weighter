using Weighter.Core;
using Weighter.Platforms;

namespace Weighter;

public static class PlatformInitializer
{
    public static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.Register<ICrossFirebaseInitService, CrossFirebaseInitService>();
    }
}