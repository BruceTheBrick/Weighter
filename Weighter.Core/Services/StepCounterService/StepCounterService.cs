namespace Weighter.Core.Services;

public class StepCounterService : IStepCounterService
{
    private readonly IStepCounterNativeService _stepCounterNativeService;
    public StepCounterService(IStepCounterNativeService stepCounterNativeService)
    {
        _stepCounterNativeService = stepCounterNativeService;
    }

    public void Initialize()
    {
        _stepCounterNativeService.Initialize();
        _stepCounterNativeService.RegisterStepsUpdatedHandler(HandleStepsUpdated);
    }

    private void HandleStepsUpdated(object? sender, StepsChangedEvent stepsChangedEvent)
    {
        Console.WriteLine($"DEBUG TEST - Steps updated: {stepsChangedEvent.Steps}");
    }

    public int GetStepsToday()
    {
        return 0;
    }

    public int GetStepsWithDate(DateTimeOffset date)
    {
        return 0;
    }
}
