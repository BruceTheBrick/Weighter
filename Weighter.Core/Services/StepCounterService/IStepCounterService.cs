namespace Weighter.Core.Services;

public interface IStepCounterService : IInitialize
{
    public int GetStepsToday();
    public int GetStepsWithDate(DateTimeOffset date);
}
