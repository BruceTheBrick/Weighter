using Weighter.Core;

namespace Weighter.Services;

public class StepCounterNativeService : IStepCounterNativeService
{
    private readonly MotionSensorManager _sensorManager;

    public StepCounterNativeService()
    {
        _sensorManager =  new MotionSensorManager();
    }

    public void Initialize()
    {
        _sensorManager.StepsChanged += StepsChanged;
        _sensorManager.Start();
    }

    private void StepsChanged(object? sender, StepsChangedEvent stepsChangedEvent)
    {
        // stepsChangedEvent.
    }

    public Dictionary<string, string> GetSteps()
    {
        return new Dictionary<string, string>();
    }

    public int GetStepsToday()
    {
        throw new NotImplementedException();
    }

    public int GetStepsWithDate(DateTimeOffset date)
    {
        throw new NotImplementedException();
    }
}
