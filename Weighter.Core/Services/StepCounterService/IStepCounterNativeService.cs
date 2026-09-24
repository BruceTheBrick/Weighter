namespace Weighter.Core.Services;

public interface IStepCounterNativeService : IInitialize
{
    public void RegisterStepsUpdatedHandler(Action<object?, StepsChangedEvent> handler);
}
