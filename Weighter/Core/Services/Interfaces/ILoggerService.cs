namespace Weighter.Core.Services.Interfaces;

public interface ILoggerService
{
    public void Log(string message);
    public void LogException(Exception exception);
}