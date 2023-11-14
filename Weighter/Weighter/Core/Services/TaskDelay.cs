namespace Weighter.Core;

public class TaskDelay : ITaskDelay
{
    private readonly IDeviceInfo _deviceInfo;
    public TaskDelay(IDeviceInfo deviceInfo)
    {
        _deviceInfo = deviceInfo;
    }
    public Task Delay(int milliseconds)
    {
        return Task.Delay(milliseconds);
    }

    public Task DelayOnIos(int milliseconds)
    {
        if (_deviceInfo.IsIos)
        {
            return Task.Delay(milliseconds);
        }

        return Task.CompletedTask;
    }

    public Task DelayOnAndroid(int milliseconds)
    {
        if (_deviceInfo.IsAndroid)
        {
            return Task.Delay(milliseconds);
        }

        return Task.CompletedTask;
    }
}