namespace Weighter.Core;

public class FirebaseInitService : IFirebaseInitService
{
    private readonly ICrossFirebaseInitService _crossFirebaseInitService;
    private readonly IFeatureToggleService _featureToggleService;

    public FirebaseInitService(
        ICrossFirebaseInitService crossFirebaseInitService,
        IFeatureToggleService featureToggleService)
    {
        _crossFirebaseInitService = crossFirebaseInitService;
        _featureToggleService = featureToggleService;
    }
    public async Task Initialize()
    {
        try
        {
            _crossFirebaseInitService.Initialize();
            await _featureToggleService.Initialize();
        }
        catch (Exception e)
        {
                
        }
    }
}