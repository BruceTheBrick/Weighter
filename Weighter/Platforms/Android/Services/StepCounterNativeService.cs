using Weighter.Droid.Core;

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
        stepsChangedEvent.
    }

    public Dictionary<string, string> GetSteps()
    {
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