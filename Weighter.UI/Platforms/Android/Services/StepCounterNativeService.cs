using Weighter.Core;

namespace Weighter.Services;

public class StepCounterNativeService : IStepCounterNativeService, IDisposable
{
    private readonly MotionSensorManager _sensorManager;
    private readonly WeakEventManager _stepsUpdatedEvent =  new ();

    public StepCounterNativeService()
    {
        _sensorManager =  new MotionSensorManager();
    }

    public void Dispose()
    {
        _sensorManager.StepsChanged -= StepsChanged;
    }

    public void Initialize()
    {
        _sensorManager.StepsChanged += StepsChanged;
        _sensorManager.Start();
    }

    public void RegisterStepsUpdatedHandler(Action<object?, StepsChangedEvent> handler)
    {
        _stepsUpdatedEvent.AddEventHandler(handler, nameof(_sensorManager.StepsChanged));
    }

    private void StepsChanged(object? sender, StepsChangedEvent stepsChangedEvent)
    {
        _stepsUpdatedEvent.HandleEvent(sender, stepsChangedEvent, nameof(_sensorManager.StepsChanged));
    }
}
