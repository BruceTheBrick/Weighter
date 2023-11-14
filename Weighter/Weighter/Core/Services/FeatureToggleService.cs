using Plugin.Firebase.RemoteConfig;

namespace Weighter.Core;

public class FeatureToggleService : IFeatureToggleService
{
    public async Task Initialize()
    {
        await CrossFirebaseRemoteConfig.Current.FetchAndActivateAsync();
        await CrossFirebaseRemoteConfig.Current.EnsureInitializedAsync();
    }
        
    public bool IsEnabled(string featureName)
    {
        return CrossFirebaseRemoteConfig.Current.GetBoolean(featureName);
    }
}