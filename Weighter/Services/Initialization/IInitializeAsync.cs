namespace Weighter.Services;

public interface IInitializeAsync : IInitializable
{
    public Task InitializeAsync();
}