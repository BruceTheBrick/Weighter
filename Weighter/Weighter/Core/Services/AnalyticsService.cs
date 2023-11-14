using Plugin.Firebase.Analytics;

namespace Weighter.Core;

public class AnalyticsService : IAnalyticsService
{
    public void TrackEvent(string eventName, string eventId, string value)
    {
        var dictionary = new Dictionary<string, object> { { eventId, value } };
        CrossFirebaseAnalytics.Current.LogEvent(eventName, dictionary );
    }
}