namespace Weighter.Core;

public interface ILoggerService
{
    public void Log(string message);
    public void LogException(Exception exception);
}