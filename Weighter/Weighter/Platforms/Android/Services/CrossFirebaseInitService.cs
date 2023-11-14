using Plugin.Firebase.Core.Platforms.Android;
using Weighter.Core;

namespace Weighter.Platforms;

public class CrossFirebaseInitService : ICrossFirebaseInitService
{
    public void Initialize()
    {
        CrossFirebase.Initialize(Platform.CurrentActivity);
    }
}