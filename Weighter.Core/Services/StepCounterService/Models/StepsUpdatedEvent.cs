namespace Weighter.Core.Services;

public record struct StepsChangedEvent(float Steps, DateTimeOffset Timestamp);
