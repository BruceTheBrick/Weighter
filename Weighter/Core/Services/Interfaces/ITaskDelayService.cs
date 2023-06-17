namespace Weighter.Core.Services.Interfaces
{
    public interface ITaskDelayService
    {
        Task DelayIos(int milliseconds);
        Task DelayAndroid(int milliseconds);
        Task Delay(int milliseconds);
    }
}