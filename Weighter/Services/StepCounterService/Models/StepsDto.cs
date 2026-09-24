namespace Weighter.Services.Models;

public class StepsDto
{
    public StepsDto(int steps,  DateTimeOffset interval)
    {
        Steps = steps;
        Interval = interval;
    }
    
    public int Steps { get; private set; }
    public DateTimeOffset Interval { get; private set; }
}