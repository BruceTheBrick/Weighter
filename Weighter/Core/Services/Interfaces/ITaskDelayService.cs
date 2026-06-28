namespace Weighter.Core;

public interface ITaskDelayService
{
    Task DelayIos(int milliseconds);
    Task DelayAndroid(int milliseconds);
    Task Delay(int milliseconds);
}