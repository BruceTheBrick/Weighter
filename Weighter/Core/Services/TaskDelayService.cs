using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.Services
{
    public class TaskDelayService : ITaskDelayService
    {
        private readonly IDeviceInfo _deviceInfo;

        public TaskDelayService(IDeviceInfo deviceInfo)
        {
            _deviceInfo = deviceInfo;
        }

        public Task DelayIos(int milliseconds)
        {
            if (_deviceInfo.Platform == DevicePlatform.iOS)
            {
                return Task.Delay(milliseconds);
            }

            return Task.CompletedTask;
        }

        public Task DelayAndroid(int milliseconds)
        {
            if (_deviceInfo.Platform == DevicePlatform.Android)
            {
                return Task.Delay(milliseconds);
            }

            return Task.CompletedTask;
        }

        public Task Delay(int milliseconds)
        {
            return Task.Delay(milliseconds);
        }
    }
}