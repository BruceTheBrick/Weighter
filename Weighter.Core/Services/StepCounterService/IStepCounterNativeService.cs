namespace Weighter.Core.Services;

public interface IStepCounterNativeService : IInitialize
{
    public Dictionary<string, string> GetSteps();
    public int GetStepsToday();
    public int GetStepsWithDate(DateTimeOffset date);
}