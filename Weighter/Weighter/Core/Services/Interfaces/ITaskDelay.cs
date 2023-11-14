namespace Weighter.Core;

public interface ITaskDelay
{
    public Task Delay(int milliseconds);
    public Task DelayOnIos(int milliseconds);
    public Task DelayOnAndroid(int milliseconds);
}