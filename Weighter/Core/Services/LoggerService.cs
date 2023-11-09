using System.Diagnostics;
using System.Text;
using Weighter.Core.Services.Interfaces;

namespace Weighter.Core.Services;

public class LoggerService : ILoggerService
{
    public void Log(string message)
    {
        Debug.WriteLine(message);
    }

    public void LogException(Exception exception)
    {
        var stringBuilder = new StringBuilder();
        while (exception.InnerException != null)
        {
            stringBuilder.AppendLine(exception.Message);
            exception = exception.InnerException;
        }

        Log(stringBuilder.ToString());
    }
}