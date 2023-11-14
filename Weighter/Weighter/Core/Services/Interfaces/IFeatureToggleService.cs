namespace Weighter.Core;

public interface IFeatureToggleService
{
    public Task Initialize();
    public bool IsEnabled(string featureName);
}