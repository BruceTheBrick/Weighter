using System.Reflection;

namespace Weighter;

public static class RegistrationManager
{
    private const string Service = "Service";
    private const string Page = "Page";
    private const string ViewModel = "ViewModel";

    public static void RegisterServices(IContainerRegistry containerRegistry)
    {
        var services = GetServicesToRegister();
        PerformServiceRegistration(containerRegistry, services);
    }

    public static void RegisterPagesForNavigation(IContainerRegistry containerRegistry)
    {
        var pages = GetPagesAndViewModelsToRegister();
        PerformPageRegistration(containerRegistry, pages);
    }

    private static void PerformPageRegistration(IContainerRegistry containerRegistry, IEnumerable<(Type page, Type[] pageViewModels)> pages)
    {
        foreach (var page in pages)
        {
            containerRegistry.RegisterForNavigation(page.page, page.pageViewModels);
        }    }z

    private static IEnumerable<(Type page, Type[] pageViewModels)> GetPagesAndViewModelsToRegister()
    {
        var allPages = typeof(App).Assembly.GetTypes().Where(t =>
            t.IsClass &&
            !t.IsAbstract &&
            t.Name.EndsWith(Page));

        return allPages.Select(p => (page: p, pageViewModels: typeof(App).Assembly.GetTypes().Where(t =>
            t.IsClass &&
            !t.IsAbstract &&
            t.Name.EndsWith(p.Name + ViewModel)).ToArray()));
    }

    private static IEnumerable<(Type service, Type[] interfaces)> GetServicesToRegister()
    {
        var allServices = typeof(App).Assembly.GetTypes().Where(t =>
            t.IsClass &&
            !t.IsAbstract &&
            t.Name.EndsWith(Service));

        // Only return services that implement at least one interface
        return allServices
            .Select(s => (service: s, interfaces: s.GetInterfaces()))
            .Where(pair => pair.interfaces is { Length: > 0 });
    }

    private static void PerformServiceRegistration(IContainerRegistry containerRegistry, IEnumerable<(Type service, Type[] interfaces)> services)
    {
        foreach (var (service, interfaces) in services)
        {
            if (ShouldRegisterAsSingleton(service))
            {
                foreach (var currentInterface in interfaces)
                {
                    containerRegistry.RegisterSingleton(service, currentInterface);
                }
            }
            else
            {
                foreach (var currentInterface in interfaces)
                {
                    containerRegistry.Register(service, currentInterface);
                }
            }
        }
    }

    private static bool ShouldRegisterAsSingleton(Type service)
    {
        return service.GetCustomAttribute<TransientServiceAttribute>() is null;
    }
}