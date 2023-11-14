namespace Weighter.Core;

public interface IDeviceInfo
{
    public bool IsAndroid { get; }
    public bool IsIos { get; }
}