using System.Diagnostics;

namespace Weighter.Core.Services;

public class StepCounterService : IStepCounterService
{
    public void Initialize()
    {
        Debug.WriteLine("Initialising step counter service");
    }
}
