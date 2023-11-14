namespace Weighter.Core;

public class AccessibilityService : IAccessibilityService
{
    public void Announce(string announcement)
    {
        SemanticScreenReader.Default.Announce(announcement);
    }
}