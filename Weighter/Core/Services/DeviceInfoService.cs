using System.Diagnostics.CodeAnalysis;

namespace Weighter.Core.Services
{
    [ExcludeFromCodeCoverage]
    public class DeviceInfoService : IDeviceInfo
    {
        public string Model => DeviceInfo.Model;
        public string Manufacturer => DeviceInfo.Manufacturer;
        public string Name => DeviceInfo.Name;
        public string VersionString => DeviceInfo.VersionString;
        public Version Version => DeviceInfo.Version;
        public DevicePlatform Platform => DeviceInfo.Platform;
        public DeviceIdiom Idiom => DeviceInfo.Idiom;
        public DeviceType DeviceType => DeviceInfo.DeviceType;
    }
}