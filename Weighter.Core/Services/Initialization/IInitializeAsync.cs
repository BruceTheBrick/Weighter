namespace Weighter.Core.Services;

public interface IInitializeAsync : IInitializable
{
    public Task InitializeAsync();
}