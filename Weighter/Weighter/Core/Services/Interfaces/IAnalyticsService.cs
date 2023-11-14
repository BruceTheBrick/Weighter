namespace Weighter.Core;

public interface IAnalyticsService
{
    public void TrackEvent(string eventName, string eventId, string value);
}