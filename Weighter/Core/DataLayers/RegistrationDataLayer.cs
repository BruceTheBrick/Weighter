namespace Weighter.Core;

public class RegistrationDataLayer : IRegistrationDataLayer
{
    private readonly IWeighterDatabase _weighterDatabase;
    private readonly ILoggerService _logger;
    public RegistrationDataLayer(
        IWeighterDatabase weighterDatabase,
        ILoggerService loggerService)
    {
        _weighterDatabase = weighterDatabase;
        _logger = loggerService;
    }

    public bool Register(RegistrationDetailsViewModel registrationDetailsViewModel)
    {
        try
        {
            _weighterDatabase.Add(registrationDetailsViewModel.User);
            registrationDetailsViewModel.LinkSettingsToUser();
            _weighterDatabase.Add(registrationDetailsViewModel.Settings);
            return true;
        }
        catch (Exception e)
        {
            _logger.LogException(e);
            return false;
        }
    }
}