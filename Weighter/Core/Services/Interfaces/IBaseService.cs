namespace Weighter.Core.Services.Interfaces
{
    public interface IBaseService
    {
        public INavigationService NavigationService { get; }
        public ILoggerService LoggerService { get; }
    }
}