using Weighter.Core;
using Plugin.Firebase.Core.Platforms.iOS;
using Plugin.Firebase.Crashlytics;

namespace Weighter.Platforms;

public class CrossFirebaseInitService : ICrossFirebaseInitService
{
    public void Initialize()
    {
        CrossFirebase.Initialize();
        CrossFirebaseCrashlytics.Current.SetCrashlyticsCollectionEnabled(true);
    }
}